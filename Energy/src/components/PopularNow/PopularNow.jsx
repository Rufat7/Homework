import Item from "./Item";
import "./PopularNow.css";
import React from "react";
import drinks from '../../EnergyDrink';

const PopularNow = () => {
  const popularDrinks = drinks.sort((a, b) => b.rating - a.rating).slice(0, 4);

  return (
    <div className="popular-now-container">
      {popularDrinks.map(drink => (
        <Item key={drink.id} drink={drink} />
      ))}
    </div>
  );
};

export default PopularNow;
