import express from "express";
import db from "../config/db.js";

const router = express.Router();

// GET /kolcsonzohelyek -> összes telephely
router.get("/", (req, res) => {
    db.query("SELECT * FROM kolcsonzohelyek", (err, results) => {
        if (err) return res.status(500).json({ error: err.message });
        res.json(results);
    });
});

// GET /kolcsonzohelyek/:id -> adott telephely
router.get("/:id", (req, res) => {
    const id = req.params.id;
    db.query("SELECT * FROM kolcsonzohelyek WHERE id = ?", [id], (err, results) => {
        if (err) return res.status(500).json({ error: err.message });
        if (results.length === 0) return res.status(404).json({ error: "Telephely nem található" });
        res.json(results[0]);
    });
});

export default router;