const BASE_URL = "http://localhost:3000"; // backend

// api.js
export const API_URL = "http://localhost:3307"; // 3307, nem 3000

export const getAutok = async () => {
  const res = await fetch(`${BASE_URL}/autok`);
  return res.json();
};

export const getAutokByRendszam = async (rendszam) => {
  const res = await fetch(`${BASE_URL}/autok/${rendszam}`);
  return res.json();
};

export const getUgyfelek = async () => {
  const res = await fetch(`${BASE_URL}/ugyfelek`);
  return res.json();
};

export const getUgyfelByNev = async (nev) => {
  const res = await fetch(`${BASE_URL}/ugyfelek/${nev}`);
  return res.json();
};

export const getKolcsonzesek = async () => {
  const res = await fetch(`${BASE_URL}/kolcsonzesek`);
  return res.json();
};

export const getKolcsonzesekByUgyfel = async (nev) => {
  const res = await fetch(`${BASE_URL}/kolcsonzesek/ugyfel/${nev}`);
  return res.json();
};

export const addKolcsonzes = async (data) => {
  const res = await fetch(`${BASE_URL}/kolcsonzesek`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(data),
  });
  return res.json();
};