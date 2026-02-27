import React from "react";
import { Link } from "react-router-dom";

const Navbar = () => (
  <nav>
    <Link to="/">Autók</Link> |{" "}
    <Link to="/kolcsonzesek">Kölcsönzések</Link> |{" "}
    <Link to="/uj-kolcsonzes">Új kölcsönzés</Link>
  </nav>
);

export default Navbar;