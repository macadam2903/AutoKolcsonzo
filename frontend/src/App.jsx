import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header.jsx";
import Footer from "./components/Footer.jsx";
import Navbar from "./components/Navbar.jsx";
import Autok from "./pages/Autok.jsx";
import Kolcsonzesek from "./pages/Kolcsonzesek.jsx";
import UjKolcsonzes from "./pages/UjKolcsonzes.jsx";

function App() {
  return (
    <Router>
      <Header />
      <Navbar />
      <div className="container">
        <Routes>
          <Route path="/" element={<Autok />} />
          <Route path="/kolcsonzesek" element={<Kolcsonzesek />} />
          <Route path="/uj-kolcsonzes" element={<UjKolcsonzes />} />
        </Routes>
      </div>
      <Footer />
    </Router>
  );
}

export default App;