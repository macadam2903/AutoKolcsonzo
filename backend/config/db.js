import mysql from "mysql2";
import dotenv from "dotenv";

dotenv.config();

const connection = mysql.createConnection({
    host: process.env.DB_HOST,
    user: process.env.DB_USER,
    password: process.env.DB_PASSWORD,
    database: process.env.DB_NAME,
    port: process.env.DB_PORT || 3307

});

connection.connect((err) => {
    if (err) {
        console.error("Hiba a csatlakozáskor:", err);
    } else {
        console.log("MySQL csatlakoztatva a szerver fut a következő linken http://localhost:" + process.env.PORT);
    }
});

export default connection;