import express from "express";
import db from "../config/db.js";

const router = express.Router();

// Összes ügyfél
router.get("/", (req, res) => {
    db.query("SELECT * FROM ugyfelek", (err, results) => {
        if (err) return res.status(500).json(err);
        res.json(results);
    });
});

// Ügyfél név alapján
router.get("/:nev", (req, res) => {
    const { nev } = req.params;
    db.query("SELECT * FROM ugyfelek WHERE nev = ?", [nev], (err, results) => {
        if (err) return res.status(500).json(err);
        if (results.length === 0) return res.status(404).json({ message: "Nincs ilyen ügyfél" });
        res.json(results[0]);
    });
});

export default router;