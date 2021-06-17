import React, { Component } from "react";
import { Container, Table, Row, Col, Form, Button } from "react-bootstrap";
import { formatDateRequest } from "../utils";

class BookEntry extends Component {
  state = {
    bookEntries: [],
    income: true,
    expense: true,
    validated: false,
  };

  componentWillMount() {
    fetch("https://localhost:44313/api/BookEntry", {
      mode: "cors",
      headers: {
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        this.setState({ bookEntries: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  componentDidMount() {
    if (this.props.location.state !== undefined)
      this.setState({ expense: false });
  }

  onFormSubmit = (e) => {
    e.preventDefault();
    const form = e.currentTarget;
    if (form.checkValidity() === false) {
      console.log("aaaa");
      e.preventDefault();
      e.stopPropagation();
      this.setState({ validated: true });
    } else {
      console.log("bbbb");

      let formElements = e.target.elements;
      const income =
        formElements.income.value === "" ? null : formElements.income.value;
      const expense =
        formElements.expense.value === "" ? null : formElements.expense.value;
      const description = formElements.description.value;
      const paymentMethodForm = formElements.paymentMethod;
      const paymentMethod = parseInt(
        paymentMethodForm.children[paymentMethodForm.selectedIndex].id,
        10
      );

      let item = {
        income,
        expense,
        description,
        paymentMethod,
      };
      let postUrl = "https://localhost:44313/api/BookEntry";
      fetch(postUrl, {
        mode: "cors",
        headers: {
          "Content-Type": "application/json",
          Authorization:
            "Bearer " +
            JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
        },
        method: "POST",
        body: JSON.stringify(item),
      })
        .then((response) => {
          if (!response.ok) {
            throw Error(response.statusText);
          }
          return response.json();
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
      this.props.history.push({
        pathname: "/",
        state: { edited: true },
      });
    }
  };

  handleIncomeExpense = (type, e) => {
    let value = e.target.value;
    if (value === "0") this.setState({ income: true, expense: true });
    else if (type === "income") this.setState({ income: true, expense: false });
    else this.setState({ income: false, expense: true });
  };

  render() {
    return (
      <Row className="mt-5">
        {JSON.parse(localStorage.getItem("loggedUser")) &&
          (JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
            "WebMaster"
          ) ||
            JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "Accountant"
            )) && (
            <Col>
              <Row>
                <h3>Libro de cuentas</h3>
              </Row>
              <Row style={{ width: "90%" }} className="mt-3">
                <Table hover bordered striped>
                  <thead>
                    <th>Fecha</th>
                    <th>Ingreso</th>
                    <th>Gasto</th>
                    <th>Método de pago</th>
                    <th>Descripción</th>
                  </thead>
                  <tbody>
                    {this.state.bookEntries.map((b) => (
                      <tr>
                        <td>{formatDateRequest(b.date)}</td>
                        <td>{b.income ? b.income : ""}</td>
                        <td>{b.expense ? b.expense : ""}</td>
                        <td>
                          {b.paymentMethod === 1 ? "Crédito" : "Efectivo"}
                        </td>
                        <td>{b.description}</td>
                      </tr>
                    ))}
                  </tbody>
                </Table>
              </Row>
            </Col>
          )}

        <Col md={3}>
          <Row>
            <h3>Nueva cuenta</h3>
          </Row>
          <Row>
            <Form
              noValidate
              validated={this.state.validated}
              onSubmit={this.onFormSubmit}
            >
              <Form.Group controlId="income">
                <Form.Label>Ingreso:</Form.Label>
                <Form.Control
                  disabled={this.state.income ? false : true}
                  onChange={(e) => this.handleIncomeExpense("income", e)}
                  type="number"
                  defaultValue={
                    this.props.location.state !== undefined
                      ? this.props.location.state
                      : 0
                  }
                  min={0}
                  max={10000}
                />
              </Form.Group>
              <Form.Group controlId="expense">
                <Form.Label>Gasto:</Form.Label>
                <Form.Control
                  disabled={this.state.expense ? false : true}
                  onChange={(e) => this.handleIncomeExpense("expense", e)}
                  type="number"
                  min={0}
                  max={10000}
                  step={0.1}
                />
              </Form.Group>
              <Form.Group controlId="paymentMethod">
                <Form.Label>Método de pago:</Form.Label>
                <Form.Control required as="select">
                  <option id={0}>Efectivo</option>
                  <option id={1}>Crédito</option>
                </Form.Control>
                <Form.Text muted>Este campo es requerido.</Form.Text>
              </Form.Group>
              <Form.Group controlId="description">
                <Form.Label>Descripción:</Form.Label>
                <Form.Control as="textarea" rows={3} />
              </Form.Group>
              <Button style={{ float: "right" }} type="submit">
                Aceptar
              </Button>
            </Form>
          </Row>
        </Col>
      </Row>
    );
  }
}

export default BookEntry;
