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

class MyReservations extends Component {
  state = {
    reservations: [
      {
        id: "1",
        date: "2021-06-05",
        state: "pending",
        paidByPoints: false,
        creditCard: null,
        boxOffice: null,
        items: [
          {
            filmScreening: {
              film: { name: "Cinema Paradiso" },
              price: 20,
              points: 20,
              room: { id: "1", name: "Sala A" },
              time: "8:00 AM",
              date: "2021-06-13",
            },
            seat: {
              room: { id: "1", name: "Sala A" },
              level: { id: "1", name: "Platea Baja" },
              section: { id: "1", name: "A" },
              seat: { id: "1" },
              time: "8:00 AM",
            },
            price: 20,
            points: 20,
          },
          {
            filmScreening: {
              film: { name: "Cinema Paradiso" },
              price: 20,
              points: 20,
              room: { id: "1", name: "Sala A" },
              time: "8:00 AM",
              date: "2021-06-13",
            },
            seat: {
              room: { id: "1", name: "Sala A" },
              level: { id: "1", name: "Platea Baja" },
              section: { id: "1", name: "A" },
              seat: { id: "2" },
            },
            price: 20,
            points: 20,
          },
        ],
      },
      {
        id: "2",
        date: "2021-06-05",
        state: "completed",
        paidByPoints: false,
        creditCard: "55544542861",
        boxOffice: null,
        items: [],
      },
      {
        id: "3",
        date: "2021-06-05",
        state: "completed",
        paidByPoints: true,
        creditCard: null,
        boxOffice: null,
        items: [],
      },
      {
        id: "4",
        date: "2021-06-05",
        state: "completed",
        paidByPoints: false,
        creditCard: null,
        boxOffice: "Taquilla A",
        items: [],
      },
      {
        id: "5",
        date: "2021-06-05",
        state: "canceled",
        paidByPoints: false,
        creditCard: null,
        boxOffice: null,
        items: [],
      },
    ],
    canBeCanceled: false,
  };

  //   componentWillMount() {
  //     fetch(
  //       `https://localhost:44334/api/PurchaseOrder/${
  //         JSON.parse(localStorage.getItem("loggedUser")).username
  //       }`,
  //       {
  //         mode: "cors",
  //       }
  //     )
  //       .then((response) => {
  //         if (!response.ok) {
  //           throw Error(response.statusText);
  //         }
  //         return response.json();
  //       })
  //       .then((response) => {
  //         this.setState({ reservations: response });
  //       })
  //       .catch(function (error) {
  //         console.log("Hubo un problema con la petición Fetch:" + error.message);
  //       });
  //   }

  statePurchaseOrder = (st) => {
    if (st === "completed") return "Completada";
    if (st === "pending") return "Pendiente";
    return "Cancelada";
  };

  variantState = (st) => {
    if (st === "completed") return "success";
    if (st === "pending") return "warning";
    return "danger";
  };

  paymentMethod = (po) => {
    if (po.paidByPoints) return "Puntos";
    if (po.boxOffice) return "Efectivo (en taquilla)";
    return "Crédito";
  };

  payPurchaseOrder = () => {};

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

    if (currentYear <= year) {
      if (currentMonth <= month) {
        if (currentDay <= day) {
          if (currentHour <= hour) {
            if (currentMinutes <= minutes) return true;
            return false;
          }
          return false;
        }
        return false;
      }
      return false;
    }
    return false;
  };

  cancelPurchaseOrder = () => {};

  cancelReservation = () => {};

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
                  <Card.Title className="ml-3 ">Fecha: {po.date}</Card.Title>
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
                      {po.state === "completed"
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
                                  {item.seat.section.name}-{item.seat.seat.id}
                                </td>
                                {po.state === "completed" && item.price && (
                                  <td>Precio: {item.price}</td>
                                )}
                                {po.state === "completed" && item.points && (
                                  <td>Puntos: {item.points}</td>
                                )}
                                {po.state !== "completed" && (
                                  <td>Precio: {item.price}</td>
                                )}
                                {!po.state !== "completed" && (
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
                                    {po.state !== "canceled" && (
                                      <Button
                                        size="sm"
                                        onClick={this.cancelReservation}
                                        variant="outline-danger"
                                        disabled={
                                          this.compareTimes(
                                            po.items[0].filmScreening.time,
                                            po.items[0].filmScreening.date
                                          )
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
                  <Row>
                    <OverlayTrigger
                      key="pay"
                      placement="top"
                      overlay={<Tooltip id={`pay`}>Pagar reservas.</Tooltip>}
                    >
                      <Button
                        onClick={this.payPurchaseOrder}
                        variant="outline-success"
                      >
                        <CreditCard2BackFill />
                      </Button>
                    </OverlayTrigger>
                  </Row>
                  <Row className="mt-2 mb-2">
                    <OverlayTrigger
                      key="cancel"
                      placement="top"
                      overlay={
                        <Tooltip id={`cancel`}>Cancelar reservas.</Tooltip>
                      }
                    >
                      <Button
                        onClick={this.cancelPurchaseOrder}
                        variant="outline-danger"
                      >
                        <XLg />
                      </Button>
                    </OverlayTrigger>
                  </Row>
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
