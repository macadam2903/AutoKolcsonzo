import express from "express";
import db from "../config/db.js";

const router = express.Router();


// GET összes
router.get("/", (req, res) => {
    const sql = `
        SELECT k.*, a.rendszam, u.nev AS ugyfel_nev
        FROM kolcsonzesek k
        JOIN autok a ON k.auto_id = a.id
        JOIN ugyfelek u ON k.ugyfel_id = u.id
    `;

    db.query(sql, (err, result) => {
        if (err) return res.status(500).json(err);
        res.json(result);
    });
});


// POST új
router.post("/", (req, res) => {
    const { auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig } = req.body;

    if (new Date(meddig) <= new Date(mettol)) {
        return res.status(400).json({ message: "Hibás dátum" });
    }

    const sql = `
        INSERT INTO kolcsonzesek 
        (auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig)
        VALUES (?, ?, ?, ?, ?)
    `;

    db.query(sql, [auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig], (err) => {
        if (err) return res.status(500).json(err);
        res.status(201).json({ message: "Sikeres mentés" });
    });
});


// DELETE
router.delete("/:id", (req, res) => {
    db.query("DELETE FROM kolcsonzesek WHERE id=?", [req.params.id], (err) => {
        if (err) return res.status(500).json(err);
        res.json({ message: "Törölve" });
    });
});

// Kölcsönzés id alapján
router.get("/:id", (req, res) => {
    const { id } = req.params;
    const sql = `
        SELECT k.*, a.rendszam, a.automarka, a.automodell, u.nev as ugyfel_nev
        FROM kolcsonzesek k
        JOIN autok a ON k.auto_id = a.id
        JOIN ugyfelek u ON k.ugyfel_id = u.id
        WHERE k.id = ?
    `;
    db.query(sql, [id], (err, results) => {
        if (err) return res.status(500).json(err);
        if (results.length === 0) return res.status(404).json({ message: "Nincs ilyen kölcsönzés" });
        res.json(results[0]);
    });
});

// GET /kolcsonzesek/ugyfel/:ugyfel_neve
router.get("/ugyfel/:nev", (req, res) => {
    const { nev } = req.params;

    const sql = `
        SELECT k.*, a.rendszam, a.automarka, a.automodell
        FROM kolcsonzesek k
        JOIN autok a ON k.auto_id = a.id
        JOIN ugyfelek u ON k.ugyfel_id = u.id
        WHERE u.nev = ?
    `;

    db.query(sql, [nev], (err, results) => {
        if (err) return res.status(500).json(err);
        if (results.length === 0) return res.status(404).json({ message: "Nincs kölcsönzés ezzel az ügyfél névvel" });
        res.json(results);
    });
});

// Ügyfél összes kölcsönzése
router.get("/ugyfel/:nev", (req, res) => {
    const { nev } = req.params;

    const sql = `
        SELECT k.*, a.rendszam, a.automarka, a.automodell
        FROM kolcsonzesek k
        JOIN autok a ON k.auto_id = a.id
        JOIN ugyfelek u ON k.ugyfel_id = u.id
        WHERE u.nev = ?
    `;

    db.query(sql, [nev], (err, results) => {
        if (err) return res.status(500).json(err);
        if (results.length === 0) return res.status(404).json({ message: "Nincs kölcsönzés ezzel az ügyfél névvel" });
        res.json(results);
    });
});

// Új kölcsönzés hozzáadása
router.post("/", (req, res) => {
    const { auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig } = req.body;

    if (!auto_id || !kolcsonzo_id || !ugyfel_id || !mettol || !meddig) {
        return res.status(400).json({ message: "Hiányzó adatok a kölcsönzéshez" });
    }

    const sql = "INSERT INTO kolcsonzesek (auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig) VALUES (?, ?, ?, ?, ?)";
    db.query(sql, [auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig], (err, result) => {
        if (err) return res.status(500).json(err);
        res.status(201).json({ message: "Kölcsönzés hozzáadva", id: result.insertId });
    });
});

export default router;