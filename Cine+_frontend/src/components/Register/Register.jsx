import React, { Component } from "react";
import { Form, Button, Row, Container, Modal } from "react-bootstrap";
import "./Register.css";

class Register extends Component {
  state = { validated: false, error: "", test: "" };

  onFormSubmit = (e) => {
    const form = e.currentTarget;
    if (form.checkValidity() === false) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({ validated: true });
    } else {
      let formElements = e.target.elements;
      let user = {
        username: formElements.username.value,
        password: formElements.password.value,
        email: formElements.email.value,
      };
      fetch("https://localhost:44313/api/User/register", {
        mode: "cors",
        headers: { "Content-Type": "application/json" },
        method: "POST",
        body: JSON.stringify(user),
      })
        .then((response) => {
          if (!response.ok) {
            throw Error(response.message);
          }
          return response.json();
        })
        .catch((error) => {
          this.setState({ error: error });
          console.log("Hubo un problema con la petición Fetch:" + error);
        });
      this.props.history.push("/");
    }
  };

  render() {
    return (
      <Container className="mt-5">
        {this.state.error !== "" && (
          <Modal.Dialog>
            <Modal.Header closeButton>
              <Modal.Title>Atención</Modal.Title>
            </Modal.Header>

            <Modal.Body>
              <p>{this.state.error}</p>
            </Modal.Body>

            <Modal.Footer>
              <Button variant="secondary">Close</Button>
            </Modal.Footer>
          </Modal.Dialog>
        )}
        <Row className="center-col mb-3">
          <h4>Registrarse</h4>
        </Row>
        <Row className="center-col">
          <Form
            noValidate
            validated={this.state.validated}
            style={{ width: "30%" }}
            onSubmit={this.onFormSubmit}
          >
            <Form.Group controlId="username">
              <Form.Label>Nombre de usuario:</Form.Label>
              <Form.Control
                required
                type="username"
                placeholder="Introduzca el nombre de usuario"
              />
              <Form.Control.Feedback type="invalid">
                Debe ingresar un nombre de usuario.
              </Form.Control.Feedback>
            </Form.Group>
            <Form.Group controlId="email">
              <Form.Label>Correo electrónico:</Form.Label>
              <Form.Control
                required
                type="email"
                placeholder="Introduzca el correo"
              />
              <Form.Control.Feedback type="invalid">
                Debe ingresar un correo electrónico.
              </Form.Control.Feedback>
            </Form.Group>
            <Form.Group controlId="password">
              <Form.Label>Contraseña:</Form.Label>
              <Form.Control required type="password" placeholder="Contraseña" />
              <Form.Control.Feedback type="invalid">
                Debe ingresar una contraseña.
              </Form.Control.Feedback>
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
