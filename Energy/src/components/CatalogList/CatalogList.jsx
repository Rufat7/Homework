import React from "react";
import "./CatalogList.css";
import drinks from "../../EnergyDrink";
import { Link } from "react-router-dom";

export default function CatalogList() {
  return (
    <div className="list-container">
      <div className="drinks-list"> {/* Обновлено название класса */}
        {drinks.map((drink) => (
          <div key={drink.id} className="card">
            <Link to={`/product/${drink.id}`}>
              <img
                src={require(`../../Energy_Picture/${drink.title}.jpg`)}
                alt={drink.name}
              />
            </Link>
            <div className="card-information">
              <Link to={`/product/${drink.id}`} className="card-link">
                <p className="card-brand">{drink.name}</p>
                <p className="card-price">{drink.price}$</p>
              </Link>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
