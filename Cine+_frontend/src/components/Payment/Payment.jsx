import React, { Component } from "react";
import { Container, Form, Col } from "react-bootstrap";
import Cards from "react-credit-cards";

class Payment extends Component {
  state = {
    purchaseOrder: undefined,
  };

  render() {
    return (
      <Container className="mt-5">
        <Form>
          <Col>
            <Form.Group controlId="paymentMethod">
              <Form.Label>Seleccione el método de pago:</Form.Label>
              <Form.Control as="select" name="paymentMethod">
                <option id={0}>Puntos</option>
                <option id={1}>Crédito</option>
              </Form.Control>
            </Form.Group>
            <Form.Group controlId="creditCard">
              <Form.Label>Número de tarjeta:</Form.Label>
              <Form.Control type="text" name="creditCard" />
            </Form.Group>
          </Col>
        </Form>
      </Container>
    );
  }
}

export default Payment;
