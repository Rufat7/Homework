import React, { useState, useEffect } from "react";
import "./Login.css";

export default function Login({ onClose, openRegister, onLoginSuccess }) {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });

  const [errors, setErrors] = useState({
    email: "",
    password: "",
  });

  const [loginError, setLoginError] = useState("");
  const [isLoading, setIsLoading] = useState(false);

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const validateForm = () => {
    const newErrors = {};
    if (!formData.email) newErrors.email = "Please enter your email";
    if (!formData.password) newErrors.password = "Please enter your password";

    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setLoginError("");
    if (validateForm()) {
      setIsLoading(true);
      try {
        const response = await fetch("https://localhost:7261/api/Users/Login", {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(formData),
        });

        setIsLoading(false);

        if (response.ok) {
          onLoginSuccess(); 
        } else {
          const errorData = await response.json();
          setLoginError(errorData.message || "Login error. Please try again later.");
        }
      } catch (error) {
        setIsLoading(false);
        setLoginError("Connection error");
      }
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal-window">
        <div className="modal-right-left-container">
          <h1>Login</h1>
          <input
            type="email"
            name="email"
            value={formData.email}
            placeholder="Email"
            onChange={handleInputChange}
          />
          {errors.email && <span className="error">{errors.email}</span>}

          <input
            type="password"
            name="password"
            value={formData.password}
            placeholder="Password"
            onChange={handleInputChange}
          />
          {errors.password && <span className="error">{errors.password}</span>}

          {loginError && <span className="error">{loginError}</span>}

          <button className="to-register-button" onClick={handleSubmit} disabled={isLoading}>
            {isLoading ? "Loading..." : "Login"}
          </button>

          <button
            className="to-register-button"
            onClick={() => {
              onClose();
              openRegister();
            }}
          >
            Don't have an account? Register
          </button>
        </div>
      </div>
    </div>
  );
}
