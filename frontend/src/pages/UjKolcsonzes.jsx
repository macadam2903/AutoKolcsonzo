import React, { useState } from "react";
import { addKolcsonzes } from "../api/api.js";
import { useLocation, useNavigate } from "react-router-dom";

const UjKolcsonzes = () => {
  const location = useLocation();
  const navigate = useNavigate();
  const selectedAuto = location.state?.auto || {};

  const [ugyfelNev, setUgyfelNev] = useState("");
  const [autoId, setAutoId] = useState(selectedAuto.id || "");
  const [kolcsonzoId, setKolcsonzoId] = useState(1); // alapértelmezett telephely
  const [mettol, setMettol] = useState("");
  const [meddig, setMeddig] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!ugyfelNev || !autoId || !mettol || !meddig) {
      alert("Minden mezőt ki kell tölteni!");
      return;
    }

    const data = {
      auto_id: parseInt(autoId),
      kolcsonzo_id: parseInt(kolcsonzoId),
      ugyfel_id: 1, // itt később a backendből választható ügyfél ID
      mettol,
      meddig,
      ugyfel: ugyfelNev,
      automarka: selectedAuto.automarka,
      automodell: selectedAuto.automodell,
      napi_dij: selectedAuto.napi_dij
    };

    try {
      await addKolcsonzes(data);
      alert("Kölcsönzés sikeresen hozzáadva!");
      navigate("/kolcsonzesek");
    } catch (err) {
      console.error(err);
      alert("Hiba történt a kölcsönzés hozzáadása során.");
    }
  };

  return (
    <div>
      <h2>Új kölcsönzés</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Ügyfél neve:</label>
          <input type="text" value={ugyfelNev} onChange={(e) => setUgyfelNev(e.target.value)} required />
        </div>
        <div>
          <label>Autó ID:</label>
          <input type="number" value={autoId} onChange={(e) => setAutoId(e.target.value)} required />
        </div>
        <div>
          <label>Kölcsönző ID:</label>
          <input type="number" value={kolcsonzoId} onChange={(e) => setKolcsonzoId(e.target.value)} required />
        </div>
        <div>
          <label>Kezdet:</label>
          <input type="date" value={mettol} onChange={(e) => setMettol(e.target.value)} required />
        </div>
        <div>
          <label>Vége:</label>
          <input type="date" value={meddig} onChange={(e) => setMeddig(e.target.value)} required />
        </div>
        <button type="submit">Hozzáadás</button>
      </form>
    </div>
  );
};

export default UjKolcsonzes;