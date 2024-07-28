import React, { useState } from "react";
import { useParams } from "react-router-dom";
import phones from "../../Phones";
import "./ProductPage.css";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";

export default function ProductPage() {
  const { title } = useParams();
  const phone = phones.find((phone) => phone.title === title);
  const [currentImage, setCurrentImage] = useState(0);
  const [selectedSizes, setSelectedSizes] = useState([]);

  const handleSizeClick = (size) => {
    if (phone.sizes.includes(size)) {
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
            <div className="product-gallery-all-images">
              {phone.images.map((image, index) => (
                <img
                  key={index}
                  src={require(`../../Phones_Picture/${image}`)}
                  alt={image}
                  className={`all-images ${
                    currentImage === index ? "active" : ""
                  }`}
                  onClick={() => setCurrentImage(index)}
                />
              ))}
            </div>
            <div className="main-image-container">
              <img
                src={require(`../../Phones_Picture/${phone.images[currentImage]}`)}
                alt={phone.name}
                className="main-image"
              />
            </div>
          </div>
          <div className="product-information">
            <h2>{phone.name}</h2>
            <h>Color: {phone.color}</h>
            <h2>{phone.price}$</h2>
            <h>Select memory :</h>
            <div className="sizes-container">
              {allSizes.map((size) => (
                <span
                  key={size}
                  className={`size ${
                    phone.sizes.includes(size)
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
              <button className="add-to-cart-button">Добавить к заказу</button>
            </div>
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}