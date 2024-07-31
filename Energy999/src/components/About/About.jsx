import React from "react";
import "./About.css";
import Footer from "../Footer/Footer";
import Header from "../Header/Header";

const aboutSections = [
    {
        title: "Наша миссия",
        description: "Узнайте о нашей миссии и ценностях, которые ведут нашу компанию вперед.",
        link: "#"
      },
      {
        title: "Наша история",
        description: "Познакомьтесь с историей и достижениями, которые определяют наш путь.",
        link: "#"
      },
      {
        title: "Наша команда",
        description: "Познакомьтесь с талантливыми людьми, стоящими за нашим успехом.",
        link: "#"
      }
];

export default function About() {
  const handleSectionClick = (title) => {
    console.log(`Clicked on section: ${title}`);

  };

  return (
    <div className="about-container">
      <Header/>
      <h1>О Нас</h1>
      <div className="about-sections">
        {aboutSections.map((section, index) => (
          <div
            key={index}
            className="about-section"
            onClick={() => handleSectionClick(section.title)}
          >
            <div className="about-content">
              <h2>{section.title}</h2>
              <p>{section.description}</p>
            </div>
          </div>
        ))}
      </div>
      <Footer/>
    </div>
  );
}
