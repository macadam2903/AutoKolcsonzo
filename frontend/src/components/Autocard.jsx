import React from "react";
import { useNavigate } from "react-router-dom";

const AutoCard = ({ auto }) => {
  const navigate = useNavigate();

  const handleKolcsonzes = () => {
    navigate("/uj-kolcsonzes", { state: { auto } });
  };

  return (
    <div className="auto-card">
      <h3>{auto.automarka} {auto.automodell}</h3>
      <p>Napi díj: {auto.napi_dij} Ft</p>
      <button onClick={handleKolcsonzes}>Kölcsönzés</button>
    </div>
  );
};

export default AutoCard;