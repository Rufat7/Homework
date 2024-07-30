import "./Item.css";
import React from 'react';
import drinks from "../../EnergyDrink";
import { Link } from "react-router-dom";
 


const Item = ({ drink }) => {
  const drinkImg = require(`../../Energy_Picture/${drink.title}.jpg`);

  return (
    <div className='popular-item-container'>
       <Link to={`/product/${drink.title}`}>
       <img src={drinkImg} alt={drink.title} />
       </Link>
      <h2>{drink.name}</h2>
      <b>{drink.price} $</b>
     
    </div>

    
  );
}

export default Item;
