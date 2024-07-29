import React, { useState } from "react";
import "./CatalogList.css";
import drinks from "../../EnergyDrink";
import { Link } from "react-router-dom";
 

export default function CatalogList() {
  return (
    <div className="list-container">
      <div className="drinks-list">
        {drinks.map((drink) => (
          <div key={drink.id} className="card">
            <Link to={`/product/${drink.title}`}>
              <img
                src={require(`../../Energy_Picture/${drink.title}.jpg`)}
                alt={drink.name}
              />
            </Link>
            <Link to={`/product/${drink.title}`}>
              <div className="card-information">
                <p className="card-brand">{drink.name}</p>
                <p className="card-price">{drink.price}$</p>
              </div>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
}
