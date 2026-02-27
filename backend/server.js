import express from "express";
import cors from "cors";
import dotenv from "dotenv";

import kolcsonzesekRoute from "./routes/kolcsonzesek.js";
import autokRoute from "./routes/autok.js";
import ugyfelekRoute from "./routes/ugyfelek.js";
import kolcsonzokRoute from "./routes/kolcsonzok.js";
import kolcsonzohelyekRoutes from "./routes/kolcsonzohelyek.js";

dotenv.config();

const app = express();

app.use(cors());
app.use(express.json());

app.use("/kolcsonzesek", kolcsonzesekRoute);
app.use("/autok", autokRoute);
app.use("/ugyfelek", ugyfelekRoute);
app.use("/kolcsonzok", kolcsonzokRoute);
app.use("/kolcsonzohelyek", kolcsonzohelyekRoutes);

app.listen(process.env.PORT, () => {
    console.log(`Szerver fut a ${process.env.PORT} porton`);
});