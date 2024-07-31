import React, { useState } from "react";
import { useParams } from "react-router-dom";
import drinks from "../../EnergyDrink";
import "./ProductPage.css";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";

export default function ProductPage() {
  const { title } = useParams();
  const drink = drinks.find((drink) => drink.title === title);
  const [currentImage, setCurrentImage] = useState(0);
  const [selectedSizes, setSelectedSizes] = useState([]);

  const handleSizeClick = (size) => {
    if (drink.sizes.includes(size)) {
      setSelectedSizes((prevSizes) =>
        prevSizes.includes(size)
          ? prevSizes.filter((s) => s !== size)
          : [...prevSizes, size]
      );
    }
  };

  const allSizes = [
    "250ml",
    "500ml"
  ];

  return (
    <div className="product-page">
      <Header />
      <div className="product-page-top">
        <div className="container-for-something"></div>
        <div className="product-container">
          <div className="product-gallery">
            <div className="main-image-container">
              <img
                src={require(`../../Energy_Picture/${drink.images[currentImage]}`)}
                alt={drink.name}
                className="main-image"
              />
            </div>
          </div>
          <div className="product-information">
            <h2>{drink.name}</h2>
            <h2>{drink.price}$</h2>
            <h>Select size :</h>
            <div className="sizes-container">
              {allSizes.map((size) => (
                <span
                  key={size}
                  className={`size ${
                    drink.sizes.includes(size)
                      ? selectedSizes.includes(size)
                        ? "available active"
                        : "available"
                      : "available"
                  }`}
                  onClick={() => handleSizeClick(size)}
                >
                  {size}
                </span>
              ))}
            </div>
            <div className="buy-cart-container">
              <button className="add-to-cart-button">Добавить в заказ</button>
            </div>
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}