import React from "react";

const KolcsonzesCard = ({ kolcsonzes }) => {
  const { ugyfel, automarka, automodell, mettol, meddig, napi_dij } = kolcsonzes;

  const mettolDate = new Date(mettol);
  const meddigDate = new Date(meddig);
  const napokSzama = Math.ceil((meddigDate - mettolDate) / (1000 * 60 * 60 * 24)) + 1;
  const osszesDij = napi_dij * napokSzama;

  return (
    <div className="kolcsonzes-card">
      <p><strong>Ügyfél:</strong> {ugyfel}</p>
      <p><strong>Autó:</strong> {automarka} {automodell}</p>
      <p><strong>Időtartam:</strong> {mettol} - {meddig} ({napokSzama} nap)</p>
      <p><strong>Fizetendő díj:</strong> {osszesDij} Ft</p>
    </div>
  );
};

export default KolcsonzesCard;