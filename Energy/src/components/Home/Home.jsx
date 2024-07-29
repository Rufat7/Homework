import React from "react";
import "./Home.css";
import BrandsCarousel from "../BrandsCarousel/BrandsCarousel";
import NewArrivalsCarousel from "../ArrivalsCarousel/NewArrivalsCarousel";

import PopularNow from "../PopularNow/PopularNow";
import { Link } from "react-router-dom";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";

export default function Home() {
  return (
    <div className="home-container">
      <Header />
      <NewArrivalsCarousel />
      <p className="best">Best Energy:</p>
      <PopularNow/>
      <BrandsCarousel />
      <Footer />
    </div>
  );
}
