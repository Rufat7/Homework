import React from "react";
import "./News.css";
import Footer from "../Footer/Footer";
import Header from "../Header/Header";

const newsArticles = [
  {
    title: "Запуск нового продукта",
    description: "Мы рады объявить о запуске нашего нового продукта. Он наполнен удивительными функциями и предлагает исключительную производительность.",
    link: "#" 
  },
  {
    title: "Достижение компании",
    description: "Мы достигли значительного этапа в нашем пути, благодаря преданным сотрудникам и лояльным клиентам.",
    link: "#" 
  },
  {
    title: "Событие в сообществе",
    description: "Присоединяйтесь к нашему предстоящему событию в сообществе, где мы продемонстрируем наши последние инновации и будем взаимодействовать с клиентами.",
    link: "#" 
  }
];

export default function News() {
  const handleArticleClick = (title) => {
    console.log(`Clicked on article: ${title}`);
  };

  return (
    <div className="news-container">
        <Header/>
      <h1>Новости</h1>
      <div className="news-articles">
        {newsArticles.map((article, index) => (
          <div
            key={index}
            className="news-article"
            onClick={() => handleArticleClick(article.title)}
          >
            <div className="news-content">
              <h2>{article.title}</h2>
              <p>{article.description}</p>
            </div>
          </div>
        ))}
      </div>
      <Footer/>
    </div>
  );
}
