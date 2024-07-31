import React, {useState, useEffect} from "react";
import "./Catalog.css";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import shoes from "../../EnergyDrink";
import CatalogFilter from "../CatalogFilter/CatalogFilter";
import CatalogList from "../CatalogList/CatalogList";

export default function Catalog() {
  const [filters, setFilters] = useState({
  });   
  
  
  return (
    <div className="catalog-container">
      <Header />
      <p className="all-shoes-p">Количество — {shoes.length}</p>

      <div className="filter-list-container">
        <CatalogFilter filters={filters} setFilters={setFilters} />
        <CatalogList filters={filters} />
      </div>
 
      <Footer />
    </div>
  );
}
