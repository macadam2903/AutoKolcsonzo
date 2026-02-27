import React, { useEffect, useState } from "react";
import { getKolcsonzesek, getKolcsonzesekByUgyfel } from "../api/api.js";
import KolcsonzesCard from "../components/Kolcsonzescard.jsx";

const Kolcsonzesek = () => {
  const [kolcsonzesek, setKolcsonzesek] = useState([]);
  const [filterNev, setFilterNev] = useState("");

  useEffect(() => {
    getKolcsonzesek().then(setKolcsonzesek).catch(console.error);
  }, []);

  const handleFilter = () => {
    if (filterNev.trim() === "") {
      getKolcsonzesek().then(setKolcsonzesek).catch(console.error);
    } else {
      getKolcsonzesekByUgyfel(filterNev.trim()).then(setKolcsonzesek).catch(console.error);
    }
  };

  return (
    <div>
      <h2>Kölcsönzések</h2>

      <div style={{ marginBottom: "1rem" }}>
        <input
          type="text"
          placeholder="Ügyfél neve"
          value={filterNev}
          onChange={(e) => setFilterNev(e.target.value)}
        />
        <button onClick={handleFilter}>Szűrés</button>
      </div>

      <div className="kolcsonzesek-list">
        {kolcsonzesek.length === 0 ? (
          <p>Nincs megjeleníthető kölcsönzés.</p>
        ) : (
          kolcsonzesek.map((k) => <KolcsonzesCard key={k.id} kolcsonzes={k} />)
        )}
      </div>
    </div>
  );
};

export default Kolcsonzesek;