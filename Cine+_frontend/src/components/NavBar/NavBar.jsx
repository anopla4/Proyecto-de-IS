import React from "react";
import "./NavBar.css";
import { Navbar, Nav, NavItem } from "react-bootstrap";
import { isLoggedIn } from "../utils";
import logo from "../../static/logo.png";

const navigation = (props) => {
  return (
    <Navbar fixed="top" bg="dark" variant="dark" expand="lg">
      <Navbar.Brand className="my-brand" href="/">
        <img
          src={logo}
          width="70"
          height="70"
          className="d-inline-block align-top"
          alt=""
        />
      </Navbar.Brand>
      <Navbar.Toggle aria-controls="responsive-navbar-nav" />
      <Navbar.Collapse id="responsive-navbar-nav">
        <Nav className="ml.auto" navbarScroll>
          <NavItem>
            <Nav.Link onCollapse="" href="/">
              Inicio
            </Nav.Link>
          </NavItem>
          <NavItem>
            <Nav.Link onCollapse="" href="/filmScreenings">
              Puestas en escena
            </Nav.Link>
          </NavItem>
          <NavItem>
            <Nav.Link href="/films">Películas</Nav.Link>
          </NavItem>
          <NavItem>
            <Nav.Link href="/myReservations">Mis reservas</Nav.Link>
          </NavItem>
        </Nav>
        <Nav className="ml-auto">
          <Nav.Item>
            {isLoggedIn() && (
              <Nav.Link>
                {JSON.parse(localStorage.getItem("loggedUser")).username}
              </Nav.Link>
            )}
          </Nav.Item>

          <Nav.Item>
            {localStorage.getItem("loggedUser") ? (
              <Nav.Link onClick={() => localStorage.removeItem("loggedUser")}>
                Cerrar sesión
              </Nav.Link>
            ) : (
              <Nav.Link href="/login">Iniciar sesión</Nav.Link>
            )}
          </Nav.Item>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
};

export default navigation;
