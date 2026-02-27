import express from "express";
import db from "../config/db.js";

const router = express.Router();


// Összes autó
router.get("/", (req, res) => {
    db.query("SELECT * FROM autok", (err, results) => {
        if (err) return res.status(500).json(err);
        res.json(results);
    });
});

// Autó rendszám alapján
router.get("/:rendszam", (req, res) => {
    const { rendszam } = req.params;
    db.query("SELECT * FROM autok WHERE rendszam = ?", [rendszam], (err, results) => {
        if (err) return res.status(500).json(err);
        if (results.length === 0) return res.status(404).json({ message: "Nincs ilyen autó" });
        res.json(results[0]);
    });
});

export default router;