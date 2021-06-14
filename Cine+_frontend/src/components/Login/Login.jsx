import React, { Component } from "react";
import { Form, Button, Toast, Row, Col, Container } from "react-bootstrap";
import isLoggedIn from "../utils";
import "./Login.css";

class Login extends Component {
  state = {
    username: undefined,
    password: undefined,
  };

  onFormSubmit = (e) => {
    let user = {
      username: this.state.username,
      password: this.state.password,
    };
    fetch("https://localhost:44334/api/Authenticate/login", {
      mode: "cors",
      headers: { "Content-Type": "application/json" },
      method: "POST",
      body: JSON.stringify(user),
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        this.props.onLoginCallback(
          user.username,
          user.password,
          response.token
        );
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
    this.props.history.push("/");
  };

  render() {
    return (
      <Container className="mt-5">
        <Row className="center-col mb-3" style={{ width: "100%" }}>
          <h3>Iniciar sesión</h3>
        </Row>
        <Row className="center-col" style={{ width: "100%" }}>
          <Form style={{ width: "30%" }}>
            <Form.Group controlId="username">
              <Form.Label>Nombre de Usuario</Form.Label>
              <Form.Control
                type="username"
                placeholder="Ponga el correo"
                onChange={(e) => {
                  this.setState({ username: e.target.value });
                }}
              />
            </Form.Group>

            <Form.Group controlId="password">
              <Form.Label>Contraseña</Form.Label>
              <Form.Control
                type="password"
                placeholder="Contraseña"
                onChange={(e) => {
                  this.setState({ password: e.target.value });
                }}
              />
            </Form.Group>
            <Button
              variant="primary"
              style={{ float: "right" }}
              onClick={this.onFormSubmit}
            >
              Aceptar
            </Button>
          </Form>
        </Row>
      </Container>
    );
  }
}

export default Login;
