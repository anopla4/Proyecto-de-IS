import React, { Component } from "react";
import { Form, Button, Row, Col, Container } from "react-bootstrap";
import "./Register.css";

class Register extends Component {
  state = {};
  onFormSubmit = (e) => {
    let formElements = e.target.elements;
    let user = {
      username: formElements.value,
      password: formElements.password,
      email: formElements.email,
    };
    fetch("https://localhost:44313/api/Authenticate/register", {
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
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
    this.props.history.push("/");
  };

  render() {
    return (
      <Container className="mt-5">
        <Row className="center-col mb-3">
          <h4>Registrarse</h4>
        </Row>
        <Row className="center-col">
          <Form style={{ width: "30%" }}>
            <Form.Group controlId="username">
              <Form.Label>Nombre de usuario:</Form.Label>
              <Form.Control
                type="username"
                placeholder="Introduzca el nombre de usuario"
              />
            </Form.Group>
            <Form.Group controlId="email">
              <Form.Label>Correo electrónico:</Form.Label>
              <Form.Control type="email" placeholder="Introduzca el correo" />
            </Form.Group>
            <Form.Group controlId="password">
              <Form.Label>Contraseña:</Form.Label>
              <Form.Control type="password" placeholder="Contraseña" />
            </Form.Group>
            <Button style={{ float: "right" }} variant="primary" type="submit">
              Aceptar
            </Button>
          </Form>
        </Row>
      </Container>
    );
  }
}

export default Register;
