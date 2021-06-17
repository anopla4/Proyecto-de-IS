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
    validated: false,
    error: "",
  };

  componentWillMount() {
    this.setState({
      modifiedPrice: this.props.location.state.modifiedPrice,
      points: this.props.location.state.points,
      purchaseOrderId: this.props.location.state.purchaseOrderId,
      paymentMethod: this.props.location.state.paymentMethod,
      state: this.props.location.state.statePayment,
    });
  }
  fixCreditCardNumber = (number) => {
    let n = "";
    for (let index = 0; index < number.length; index++) {
      const element = number[index];
      if (index % 4 === 0 && index !== 0) n = n + " " + element;
      else n = n + element;
    }
    return n;
  };

  onFormSubmit = (e) => {
    e.preventDefault();
    const form = e.currentTarget;
    let formElements = e.target.elements;
    let income = formElements.creditCard.value;
    if (
      income.split(" ").length !== 4 ||
      income[4] !== " " ||
      income[9] !== " " ||
      income[14] !== " "
    ) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({ error: "El número de tarjeta es incorrecto." });
    }
    if (form.checkValidity() === false) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({ validated: true });
    } else {
      let formElements = e.target.elements;
      let income = formElements.creditCard.value;
      let id = this.state.purchaseOrderId;
      fetch(`https://localhost:44313/api/PurchaseOrder/${id}/${income}`, {
        mode: "cors",
        headers: {
          "Content-Type": "application/json",
          Authorization:
            "Bearer " +
            JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
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
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
    }
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
          <Form
            noValidate
            validated={this.state.validated}
            onSubmit={this.onFormSubmit}
            className="mt-3"
          >
            <Col>
              <Form.Group controlId="creditCard">
                <Form.Label>Número de tarjeta:</Form.Label>
                <Form.Control
                  required
                  disabled={
                    this.state.paymentMethod === "1" || this.state.state === 0
                      ? false
                      : true
                  }
                  type="text"
                  name="creditCard"
                />
                <Form.Control.Feedback>
                  {this.state.error}
                </Form.Control.Feedback>
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
