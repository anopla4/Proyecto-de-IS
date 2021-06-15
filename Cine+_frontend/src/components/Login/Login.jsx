import React, { Component } from "react";
import { Form, Button, Toast, Row, Col, Container } from "react-bootstrap";
import isLoggedIn from "../utils";
import "./Login.css";

class Login extends Component {
  state = {
    email: undefined,
    password: undefined,
  };

  onFormSubmit = (e) => {
    let user = {
      email: this.state.email,
      password: this.state.password,
    };
    fetch("https://localhost:44313/api/User/login", {
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
          user.email,
          user.password,
          response.roles,
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
            <Form.Group controlId="email">
              <Form.Label>Correo electrónico</Form.Label>
              <Form.Control
                type="email"
                placeholder="Ponga el correo"
                onChange={(e) => {
                  this.setState({ email: e.target.value });
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
