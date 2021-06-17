import React, { Component } from "react";
import {
  Button,
  Card,
  Row,
  Col,
  Badge,
  OverlayTrigger,
  Tooltip,
  Accordion,
  Table,
} from "react-bootstrap";
import { CreditCard2BackFill, XLg, ThreeDots } from "react-bootstrap-icons";
import { formatDateRequest } from "../utils";

class MyReservations extends Component {
  state = {
    reservations: [],
    canBeCanceled: false,
  };

  componentWillMount() {
    fetch(
      `https://localhost:44313/api/PurchaseOrder/byUser/${
        JSON.parse(localStorage.getItem("loggedUser")).username
      }`,
      {
        mode: "cors",
        headers: {
          Authorization:
            "Bearer " +
            JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
        },
      }
    )
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        this.setState({ reservations: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  statePurchaseOrder = (st) => {
    if (st === 1) return "Completada";
    if (st === 0) return "Pendiente";
    return "Cancelada";
  };

  variantState = (st) => {
    if (st === 1) return "success";
    if (st === 0) return "warning";
    return "danger";
  };

  paymentMethod = (po) => {
    if (po.paidByPoints) return "Puntos";
    if (po.boxOffice) return "Efectivo (en taquilla)";
    return "Crédito";
  };

  payPurchaseOrder = (id, price, paymentMethod) => {
    console.log(paymentMethod);
    this.props.history.push({
      pathname: "/payment",
      state: {
        modifiedPrice: price,
        purchaseOrderId: id,
        statePayment: paymentMethod,
      },
    });
  };

  compareTimes = (time, date) => {
    let now = new Date();
    let currentDay = now.getDate();
    let currentMonth = now.getMonth() + 1;
    let currentYear = now.getFullYear();
    let currentHour = now.getHours();
    let currentMinutes = now.getMinutes();
    let tempTime = time.split(" ");
    let t = tempTime[0].split(":");
    let hour = parseInt(t[0], 10);
    if (tempTime[1] === "PM") hour = hour + 12;
    let minutes = parseInt(t[1], 10);
    let tempDate = date.split("-");
    let year = parseInt(tempDate[0], 10);
    let month = parseInt(tempDate[1], 10);
    let day = parseInt(tempDate[2], 10);

    if (currentYear === year) {
      if (currentMonth === month) {
        if (currentDay === day) {
          if (currentHour <= hour) {
            if (currentMinutes <= minutes) return true;
            return false;
          } else if (currentHour < hour) return true;
          return false;
        } else if (currentDay < day) return true;
        return false;
      } else if (currentMonth < month) return true;
      return false;
    } else if (currentYear < year) return true;
    return false;
  };

  cancelPurchaseOrder = (id) => {
    fetch(`https://localhost:44313/api/PurchaseOrder/${id}`, {
      mode: "cors",
      headers: {
        "Content-Type": "application/json",
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
      method: "DELETE",
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        } else {
          return response.json();
        }
      })

      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  };

  cancelReservation = (purchaseOrderId, reservation) => {
    var formdata = new FormData();
    console.log(reservation.id);
    formdata.append(`itemsIds[${0}]`, reservation.id);
    console.log(formdata);
    fetch(`https://localhost:44313/api/PurchaseOrder/${purchaseOrderId}`, {
      mode: "cors",
      headers: {
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
      method: "PATCH",
      body: formdata,
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        } else {
          return response.json();
        }
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  };

  render() {
    return (
      <Accordion className="mt-5">
        <Row className="mb-3 ml-3">
          <h3>Sus reservas en Cine+</h3>
        </Row>
        <Row className="justify-content-center">
          {this.state.reservations.map((po) => (
            <Card border="secondary" style={{ width: "80%" }} className="mt-3">
              <Row className="mt-3">
                <Col>
                  <Card.Title className="ml-3 ">
                    Fecha: {formatDateRequest(po.date)}
                  </Card.Title>
                  <Card.Subtitle className="ml-3">
                    <Row className="ml-3">
                      Estado del pago:
                      <Badge
                        className="ml-2"
                        variant={this.variantState(po.state)}
                      >
                        {this.statePurchaseOrder(po.state)}.
                      </Badge>
                    </Row>
                    <Row className="ml-3">
                      Método de pago:{" "}
                      {po.state === 1
                        ? this.paymentMethod(po)
                        : this.statePurchaseOrder(po.state)}
                    </Row>
                    {po.items.length > 0 && (
                      <Row className="ml-3 mt-3 mb-3">
                        <Accordion.Toggle
                          as={Button}
                          size="sm"
                          variant="outline-secondary"
                          eventKey={po.id}
                        >
                          {po.items.length} reservaciones {"  "}
                          <ThreeDots />
                        </Accordion.Toggle>
                      </Row>
                    )}
                  </Card.Subtitle>
                  {po.items.length > 0 && (
                    <Accordion.Collapse eventKey={po.id}>
                      <Card.Body>
                        <h6>Película: {po.items[0].filmScreening.film.name}</h6>
                        <Table>
                          <tbody>
                            {po.items.map((item) => (
                              <tr>
                                <td>
                                  {item.seat.room.name}-{item.seat.level.name}-
                                  {item.seat.section.name}-{item.seat.seat.code}
                                </td>
                                {po.state === 1 && item.price && (
                                  <td>Precio: {item.price}</td>
                                )}
                                {po.state === 1 && item.points && (
                                  <td>Puntos: {item.points}</td>
                                )}
                                {po.state !== 1 && (
                                  <td>Precio: {item.price}</td>
                                )}
                                {!po.state !== 1 && (
                                  <td>Puntos: {item.points}</td>
                                )}
                                <td>
                                  <OverlayTrigger
                                    key="cancelReservation"
                                    placement="top"
                                    overlay={
                                      <Tooltip id={`cancelReservation`}>
                                        Cancelar reserva (hasta dos horas antes
                                        de la presentación).
                                      </Tooltip>
                                    }
                                  >
                                    {po.state !== 2 && (
                                      <Button
                                        size="sm"
                                        onClick={() =>
                                          this.cancelReservation(po.id, item)
                                        }
                                        variant="outline-danger"
                                        disabled={
                                          this.compareTimes(
                                            po.items[0].filmScreening.time,
                                            formatDateRequest(
                                              po.items[0].filmScreening.date
                                            )
                                          ) && po.state === 1
                                            ? false
                                            : true
                                        }
                                      >
                                        <XLg />
                                      </Button>
                                    )}
                                  </OverlayTrigger>
                                </td>
                              </tr>
                            ))}
                          </tbody>
                        </Table>
                      </Card.Body>
                    </Accordion.Collapse>
                  )}
                </Col>
                <Col md={1}>
                  {po.state === 0 && (
                    <Row>
                      <OverlayTrigger
                        key="pay"
                        placement="top"
                        overlay={<Tooltip id={`pay`}>Pagar reservas.</Tooltip>}
                      >
                        <Button
                          onClick={() =>
                            this.payPurchaseOrder(
                              po.id,
                              po.items
                                .map((c) => c.price)
                                .reduce(function (acc, val) {
                                  return acc + val;
                                }, 0),
                              po.state
                            )
                          }
                          variant="outline-success"
                        >
                          <CreditCard2BackFill />
                        </Button>
                      </OverlayTrigger>
                    </Row>
                  )}
                  {po.state === 1 && (
                    <Row className="mt-2 mb-2">
                      <OverlayTrigger
                        key="cancel"
                        placement="top"
                        overlay={
                          <Tooltip id={`cancel`}>Cancelar reservas.</Tooltip>
                        }
                      >
                        <Button
                          onClick={() => this.cancelPurchaseOrder(po.id)}
                          variant="outline-danger"
                        >
                          <XLg />
                        </Button>
                      </OverlayTrigger>
                    </Row>
                  )}
                </Col>
              </Row>
            </Card>
          ))}
        </Row>
      </Accordion>
    );
  }
}

export default MyReservations;
