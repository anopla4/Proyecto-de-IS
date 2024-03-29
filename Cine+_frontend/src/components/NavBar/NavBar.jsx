import React from "react";
import "./NavBar.css";
import { Navbar, Nav, NavItem } from "react-bootstrap";
import { isLoggedIn } from "../utils";
import logo from "../../static/logo.png";
import { useState } from "react";

const Navigation = (props) => {
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

          {JSON.parse(localStorage.getItem("loggedUser")) &&
            JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "Accountant"
            ) && (
              <NavItem>
                <Nav.Link href="/bookEntry">Contabilidad</Nav.Link>
              </NavItem>
            )}
          {JSON.parse(localStorage.getItem("loggedUser")) &&
            JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "WebMaster"
            ) && (
              <NavItem>
                <Nav.Link href="/webMaster">Modificar roles</Nav.Link>
              </NavItem>
            )}
          {JSON.parse(localStorage.getItem("loggedUser")) &&
            (JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "WebMaster"
            ) ||
              JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
                "Admin"
              )) && (
              <NavItem>
                <Nav.Link href="/statistics">Estadísticas</Nav.Link>
              </NavItem>
            )}
        </Nav>
        <Nav className="ml-auto">
          <Nav.Item>
            {isLoggedIn() && (
              <Nav.Link>
                {JSON.parse(localStorage.getItem("loggedUser")).email}
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
          <Nav.Item>
            <Nav.Link href="/register">Registrarse</Nav.Link>
          </Nav.Item>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
};

export default Navigation;
