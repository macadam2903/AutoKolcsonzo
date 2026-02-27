import express from "express";
import db from "../config/db.js";

const router = express.Router();

router.get("/", (req, res) => {
    db.query("SELECT * FROM kolcsonzohelyek", (err, result) => {
        if (err) return res.status(500).json(err);
        res.json(result);
    });
});

export default router;