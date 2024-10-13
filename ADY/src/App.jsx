import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/navbar/Navbar';
import Footer from './components/footer/Footer';
import Home from './components/home/Home';
import Train from './components/train/Train';
import Detail from './components/train/Detail';
import Checkout from './components/checkout/Checkout';
import About from './components/about/About';
import Theme from './components/theme/Theme'; // Предположим, что у вас есть компонент Theme

function App() {
  const [theme, setTheme] = useState(localStorage.getItem('theme') || 'light');

  useEffect(() => {
    document.documentElement.classList.toggle('dark', theme === 'dark');
    localStorage.setItem('theme', theme);
  }, [theme]);

  const toggleTheme = () => {
    setTheme(theme === 'dark' ? 'light' : 'dark');
  };

  return (
    <Router>
      <div className='w-full min-h-screen bg-neutral-50 dark:bg-neutral-950 text-neutral-800 dark:text-neutral-300 flex flex-col overflow-hidden'>
        <Theme toggleTheme={toggleTheme} theme={theme} />
        <Navbar />  
        <Routes> 
          <Route path="/" element={<Home theme={theme} />} /> 
          <Route path="/train" element={<Train theme={theme} />} />
          <Route path="/about" element={<About theme={theme} />} />
          <Route path="/train/train-details" element={<Detail />} />
          <Route path="/train/train-details/checkout" element={<Checkout />} />
        </Routes>
        <Footer />
      </div>
    </Router>
  )
}

export default App;
