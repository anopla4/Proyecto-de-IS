import React, { Component } from "react";
import { Form, Button, Row, Container, Modal } from "react-bootstrap";
import isLoggedIn from "../utils";
import "../../containers/App/App.css";

class Login extends Component {
  state = {
    email: undefined,
    password: undefined,
    validated: false,
    error: "",
  };

  onFormSubmit = (e) => {
    e.preventDefault();

    const form = e.currentTarget;

    if (form.checkValidity() === false) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({ validated: true });
    } else {
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
        .then((response) => response.json())
        .then((response) => {
          if (response.status === 0) {
            this.setState({ error: response.message });
          } else {
            this.props.onLoginCallback(
              user.email,
              user.password,
              response.roles,
              response.token,
              response.id,
              response.userName,
              response.clubMember
            );
            this.props.history.push("/");
          }
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
      this.props.history.push("/");
    }
  };

  render() {
    return (
      <Container className="mt-5">
        {this.state.error !== "" && (
          <Modal.Dialog>
            <Modal.Header>
              <Modal.Title>Atención</Modal.Title>
            </Modal.Header>

            <Modal.Body>
              <p>{this.state.error}</p>
            </Modal.Body>

            <Modal.Footer>
              <Button
                onClick={() => this.setState({ error: "" })}
                variant="secondary"
              >
                Close
              </Button>
            </Modal.Footer>
          </Modal.Dialog>
        )}
        <Row className="center-col mb-3" style={{ width: "100%" }}>
          <h3>Iniciar sesión</h3>
        </Row>
        <Row className="center-col" style={{ width: "100%" }}>
          <Form
            onSubmit={this.onFormSubmit}
            noValidate
            validated={this.state.validated}
            style={{ width: "30%" }}
          >
            <Form.Group controlId="email">
              <Form.Label>Correo electrónico</Form.Label>
              <Form.Control
                required
                type="email"
                placeholder="Introduzca el correo"
                onChange={(e) => {
                  this.setState({ email: e.target.value });
                }}
              />
              <Form.Control.Feedback type="invalid">
                Debe ingresar el correo electrónico.
              </Form.Control.Feedback>
            </Form.Group>

            <Form.Group controlId="password">
              <Form.Label>Contraseña</Form.Label>
              <Form.Control
                required
                type="password"
                placeholder="Contraseña"
                onChange={(e) => {
                  this.setState({ password: e.target.value });
                }}
              />
              <Form.Control.Feedback type="invalid">
                Debe ingresar la contraseña.
              </Form.Control.Feedback>
            </Form.Group>
            <Button variant="primary" style={{ float: "right" }} type="submit">
              Aceptar
            </Button>
          </Form>
        </Row>
      </Container>
    );
  }
}

export default Login;
