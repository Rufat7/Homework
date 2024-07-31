import React from 'react'
import './Footer.css'

export default function Footer() {
  return (
<footer className="footer">
      <div className="footer-section">
        <h4>О нас</h4>
        <ul>
          <li>
            <a href="#about">Наша Компания</a>
          </li>
          <li>
            <a href="#contact">История</a>
          </li>
          
          <li>
            <a href="#contact">Вакансия</a>
          </li>
        </ul>
      </div>
      <div className="footer-section">
        <h4>ДОПОЛНИТЕЛЬНОЕ ЮРИДИЧЕСКОЕ ОБОСНОВАНИЕ</h4>
        <ul>
          <li>
            <a href="#faq">Условия использования</a>
          </li>
          <li>
            <a href="#support">Политика конфиденциаль-
            ности</a>
          </li>
          <li>
            <a href="#privacy">Установки cookie-файлов</a>
          </li>
          <li>
            <a href="#privacy">Политика "cookie"</a>
          </li>
        </ul>
      </div>
      
    </footer>
  )
}
