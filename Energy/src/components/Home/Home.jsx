import React from "react";
import "./Home.css";
import Brands from "../Brands/Brands";
import NewArrivals from "../Arrivals/NewArrivals";

import PopularNow from "../PopularNow/PopularNow";
import { Link } from "react-router-dom";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";

export default function Home() {
  return (
    <div className="home-container">
      <Header />
      <NewArrivals />
      <p className="best">Популярные в продаже:</p>
      <PopularNow/>
      <Brands />
      <Footer />
    </div>
  );
}
