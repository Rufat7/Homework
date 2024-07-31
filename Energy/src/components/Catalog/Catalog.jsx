import React, {useState, useEffect} from "react";
import "./Catalog.css";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import drinks from "../../EnergyDrink";
import CatalogFilter from "../Filter/Filter";
import CatalogList from "../List/List";

export default function Catalog() {
  const [filters, setFilters] = useState({
  });   
  
  
  return (
    <div className="catalog-container">
      <Header />
      <p className="all-shoes-p">Количество — {drinks.length}</p>

      <div className="filter-list-container">
        <CatalogFilter filters={filters} setFilters={setFilters} />
        <CatalogList filters={filters} />
      </div>
 
      <Footer />
    </div>
  );
}
