import React, { Component } from "react";
import { Container, Form, Col, Badge, Row, Button } from "react-bootstrap";
import "../../containers/App/App.css";

class Payment extends Component {
  state = {
    purchaseOrder: undefined,
    paymentMethod: 0,
    points: [],
    modifiedPrice: undefined,
    purchaseOrderId: undefined,
  };

  componentWillMount() {
    this.setState({
      modifiedPrice: this.props.location.state.modifiedPrice,
      points: this.props.location.state.points,
      purchaseOrderId: this.props.location.state.purchaseOrderId,
      paymentMethod: this.props.location.state.paymentMethod,
    });
  }
  fixCreditCardNumber = (number) => {
    let n = "";
    for (let index = 0; index < number.length; index++) {
      const element = number[index];
      if (index % 4 === 0 && index !== 0) n = n + " " + element;
      else n = n + element;
    }
    console.log(n);
    return n;
  };
  onFormSubmit = (e) => {
    e.preventDefault();
    let formElements = e.target.elements;
    let income = this.fixCreditCardNumber(formElements.creditCard.value);
    let id = this.state.purchaseOrderId;
    fetch(`https://localhost:44313/api/PurchaseOrder/${id}/${income}`, {
      mode: "cors",
      headers: {
        "Content-Type": "application/json",
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
      method: "PATCH",
      body: JSON.stringify({ purchaseOrderId: id, creditCard: income }),
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        this.props.history.push("/myReservations");
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  };

  render() {
    return (
      <Container className="mt-5">
        <h3 style={{ paddingLeft: "10%" }}>Efectuar pago</h3>
        <Row className="justify-content-end">
          <h4>
            CUP{" "}
            <Badge size="lg" variant="secondary">
              {" "}
              {this.state.modifiedPrice}
            </Badge>
          </h4>
        </Row>

        <Row className="center-col" style={{ width: "100%" }}>
          <Form onSubmit={this.onFormSubmit} className="mt-3">
            <Col>
              <Form.Group controlId="creditCard">
                <Form.Label>Número de tarjeta:</Form.Label>
                <Form.Control
                  disabled={this.state.paymentMethod === "1" ? false : true}
                  type="text"
                  name="creditCard"
                />
                <Form.Text muted>El formato es XXXX XXXX XXXX XXXX.</Form.Text>
              </Form.Group>
            </Col>
            <Button type="submit" style={{ float: "right" }}>
              Aceptar
            </Button>
          </Form>
        </Row>
      </Container>
    );
  }
}

export default Payment;
