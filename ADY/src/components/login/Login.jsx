import React, { useState } from "react";
import x from "../../assets/x.svg";
import "./Login.css";

export default function Login({ onClose, openRegister }) {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });

  const [errors, setErrors] = useState({
    email: "",
    password: "",
  });

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const validateForm = () => {
    const newErrors = {};
    if (!formData.email) newErrors.email = "Пожалуйста, введите email";
    if (!formData.password) newErrors.password = "Пожалуйста, введите пароль";

    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (validateForm()) {
      
      console.log("Форма отправлена");
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal-window">
        <button className="close-modal" onClick={onClose}>
          <img src={x} alt="close-btn" />
        </button>
        <div className="modal-right-left-container">
          <h1>Вход</h1>
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
          <button className="log-in-button" onClick={handleSubmit}>
            Войти
          </button>
          <button
            className="to-registration-button"
            onClick={() => {
              onClose();
              openRegister();
            }}
          >
            Регистрация
          </button>
        </div>
      </div>
    </div>
  );
}