import React, { useEffect, useState } from "react";
import { getAutok } from "../api/api.js";
import AutoCard from "../components/Autocard.jsx";

const Autok = () => {
  const [autok, setAutok] = useState([]);

  useEffect(() => {
    getAutok().then(setAutok).catch(console.error);
  }, []);

  return (
    <div>
      <h2>Autók</h2>
      <div className="autok-grid">
        {autok.map((auto) => (
          <AutoCard key={auto.id} auto={auto} />
        ))}
      </div>
    </div>
  );
};

export default Autok;