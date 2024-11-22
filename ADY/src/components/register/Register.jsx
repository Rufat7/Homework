import React, { useState } from "react";
import x from "../../assets/x.svg";
import "./Register.css";

export default function Register({ onClose, openLogin }) {
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    confirmPassword: "",
  });

  const [errors, setErrors] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    confirmPassword: "",
  });

  const [isLoading, setIsLoading] = useState(false);
  const [registerError, setRegisterError] = useState("");

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const validateForm = () => {
    const newErrors = {};
    if (!formData.firstName) newErrors.firstName = "Please enter your first name";
    if (!formData.lastName) newErrors.lastName = "Please enter your last name";
    if (!formData.email) newErrors.email = "Please enter your email";
    if (!formData.password) newErrors.password = "Please enter your password";
    if (!formData.confirmPassword)
      newErrors.confirmPassword = "Please confirm your password";
    else if (formData.password !== formData.confirmPassword)
      newErrors.confirmPassword = "Passwords do not match";

    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setRegisterError("");
    if (validateForm()) {
      setIsLoading(true);
      try {
        const response = await fetch("https://localhost:7261/api/Users/Registration", {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(formData),
        });

        setIsLoading(false);

        if (response.ok) {
          alert("Registration successful");
          onClose(); 
          openLogin(); 
        } else {
          const errorData = await response.json();
          setRegisterError(errorData.message || "Registration error. Please try again later.");
        }
      } catch (error) {
        setIsLoading(false);
        setRegisterError("Connection error");
      }
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal-window">
        <div className="modal-window-container">
          <h1>Register</h1>
          
          <input
            type="text"
            name="firstName"
            value={formData.firstName}
            placeholder="First Name"
            onChange={handleInputChange}
            className="input-field" 
          />
          {errors.firstName && <span className="error">{errors.firstName}</span>}

          <input
            type="text"
            name="lastName"
            value={formData.lastName}
            placeholder="Last Name"
            onChange={handleInputChange}
            className="input-field"  
          />
          {errors.lastName && <span className="error">{errors.lastName}</span>}

          <input
            type="email"
            name="email"
            value={formData.email}
            placeholder="Email"
            onChange={handleInputChange}
            className="input-field"  
          />
          {errors.email && <span className="error">{errors.email}</span>}

          <input
            type="password"
            name="password"
            value={formData.password}
            placeholder="Password"
            onChange={handleInputChange}
            className="input-field"  
          />
          {errors.password && <span className="error">{errors.password}</span>}

          <input
            type="password"
            name="confirmPassword"
            value={formData.confirmPassword}
            placeholder="Confirm Password"
            onChange={handleInputChange}
            className="input-field"  
          />
          {errors.confirmPassword && (
            <span className="error">{errors.confirmPassword}</span>
          )}

          {registerError && <span className="error">{registerError}</span>}

          <button className="register-button" onClick={handleSubmit} disabled={isLoading}>
            {isLoading ? "Loading..." : "Register"}
          </button>

          <button
            className="to-login-button"
            onClick={() => {
              onClose();
              openLogin();
            }}
          >
            Already have an account? Login
          </button>
        </div>
      </div>
    </div>
  );
}