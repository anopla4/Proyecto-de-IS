import React, { Component } from "react";
import { Form, Button } from "react-bootstrap";

class Register extends Component {
  state = {};
  render() {
    return (
      <Form>
        <Form.Group controlId="register">
          <Form.Label>Nombre de usuario:</Form.Label>
          <Form.Control
            type="username"
            placeholder="Introduzca el nombre de usuario"
          />
        </Form.Group>
        <Form.Group controlId="register">
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
    );
  }
}

export default Register;
