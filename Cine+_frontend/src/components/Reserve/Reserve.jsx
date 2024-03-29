import React, { Component } from "react";
import { formatDateRequest, groupBy } from "../utils";
import {
  Container,
  Form,
  Row,
  Col,
  Button,
  ListGroupItem,
  ListGroup,
  Popover,
  OverlayTrigger,
  Tooltip,
  Modal,
  Badge,
} from "react-bootstrap";
import "./Reserve.css";
import { TrashFill, Cart, CartPlus } from "react-bootstrap-icons";
import { withRouter } from "react-router-dom";

class Reserve extends Component {
  state = {
    selectedPriceModifications: [],
    seats: [],
    selectedRoom: undefined,
    availables: undefined,
    filmScreeningSelected: undefined,
    grouped: [],
    takenSeats: [],
    boxOffice: undefined,
    prices: [],
    points: [],
    paymentMethod: 0,
    await: false,
    error: "",
  };

  componentWillMount() {
    let filmScreeningSelected = this.props.location.state.filmScreeningSelected;

    let selectedPriceModifications = [];
    filmScreeningSelected[0].priceModifications.forEach((element) => {
      var selected = element.optional ? false : true;
      selectedPriceModifications.push({ mod: element, selected: selected });
    });
    this.setState({
      filmScreeningSelected: filmScreeningSelected,
      film: filmScreeningSelected[0].film,
      date: filmScreeningSelected[0].date,
      time: filmScreeningSelected[0].startTime,
      selectedPriceModifications: selectedPriceModifications,
    });
  }

  componentDidMount() {
    fetch(
      `https://localhost:44313/api/FilmScreening/${
        this.props.location.state.filmScreeningSelected[0].film.film.id
      }/
    ${formatDateRequest(
      this.props.location.state.filmScreeningSelected[0].date
    )}/${this.props.location.state.filmScreeningSelected[0].startTime}`,
      {
        mode: "cors",
      }
    )
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        this.setState({
          seats: response,
          grouped: groupBy(response, ["room.id", "level.id", "section.id"]),
          selectedRoom: response[0].room.id,
          availables: response.filter((c) => c.available === true).length,
        });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  onChangeSelectedRoom = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    this.setState({ selectedRoom: id });
  };

  onSelectSeat = (e, s, filmScreening, levelIncrement) => {
    let price = this.setPrice(levelIncrement, filmScreening);
    let point = filmScreening.points;
    let seat = e.target.id;
    if (!this.state.takenSeats.map((c) => c.seat.id).includes(seat)) {
      let newSeats = [...this.state.takenSeats, s];
      let newPrices = [...this.state.prices, price];
      let newPoints = [...this.state.points, point];
      this.setState({
        takenSeats: newSeats,
        prices: newPrices,
        points: newPoints,
      });
    }
  };

  handleDeleteSeat = (idS, i) => {
    let newSeats = this.state.takenSeats.filter((c) => c.seat.id !== idS);
    let newPrices = [...this.state.prices].filter((c, index) => index !== i);
    let newPoints = [...this.state.points].filter((c, index) => index !== i);
    this.setState({
      takenSeats: newSeats,
      prices: newPrices,
      points: newPoints,
    });
  };

  getTickets = (e) => {
    let seats = this.state.seats
      .filter((c) => c.available === true)
      .slice(0, e.target.value);
    let newPoints = [...this.state.points];
    let newPrices = [...this.state.prices];
    let newSeats = [...this.state.takenSeats];

    seats.forEach((element) => {
      let price = this.setPrice(
        element.level.percentOfPriceIncrement,
        this.state.filmScreeningSelected[0]
      );
      let point = this.state.filmScreeningSelected[0].points;
      let seat = element.seat;
      newSeats = [...newSeats, seat];
      newPrices = [...newPrices, price];
      newPoints = [...newPoints, point];
    });
    this.setState({ takenSeats: seats, prices: newPrices, points: newPoints });
  };

  setBoxOffice = (e) => {
    this.setState({ boxOffice: e.target.value });
  };

  setPrice = (levelPercent, filmScreening) => {
    let price =
      filmScreening.price + filmScreening.price * (levelPercent / 100);
    return price;
  };

  totalPrice = () => {
    const total = this.state.takenSeats
      .map((seat) =>
        this.setPrice(
          seat.level.percentOfPriceIncrement,
          this.state.filmScreeningSelected[0]
        )
      )
      .reduce(function (acc, val) {
        return acc + val;
      }, 0);
    return total;
  };

  modifiedPrice = () => {
    let price = this.totalPrice();
    this.state.selectedPriceModifications
      .filter((c) => c.selected === true)
      .forEach((element) => {
        var count = price * (element.mod.priceModification.value / 100);
        if (element.mod.priceModification.type === "Descuento") {
          price = price - count;
        } else {
          price = price + count;
        }
      });
    return price;
  };

  changePriceModification = (index) => {
    let nPriceModifications = [...this.state.selectedPriceModifications];
    nPriceModifications[index].selected = !nPriceModifications[index].selected;
    this.setState({ selectedPriceModifications: nPriceModifications });
  };

  checkPending = (id) => {
    console.log("aaaa");
    fetch(`https://localhost:44313/api/PurchaseOrder/${id}/check`, {
      mode: "cors",
      headers: {
        "Content-Type": "application/json",
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
      method: "PATCH",
      body: {},
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

  onFormSubmit = (e) => {
    e.preventDefault();

    let filmScreening = this.state.filmScreeningSelected.filter(
      (c) => c.room.id === this.state.selectedRoom
    )[0];
    let takenSeats = this.state.takenSeats;
    let prices = this.state.prices;
    let points = this.state.points;
    let paymentMethod = this.state.paymentMethod;
    let modifiedPrice = this.modifiedPrice();
    let userId = JSON.parse(localStorage.getItem("loggedUser")).userId;
    let purchaseOrderId = undefined;
    let boxOffice = this.state.boxOffice;
    var formdata = new FormData();
    formdata.append("purchaseOrder.userId", userId);
    formdata.append("purchaseOrder.date", this.state.date);
    formdata.append("purchaseOrder.purchaseTime", this.state.time);
    if (
      JSON.parse(localStorage.getItem("loggedUser")).roles.includes("Worker") ||
      JSON.parse(localStorage.getItem("loggedUser")).roles.includes("WebMaster")
    )
      formdata.append(
        "purchaseOrder.boxOffice",
        this.state.boxOffice === undefined ? "" : this.state.boxOffice
      );
    if (this.state.paymentMethod === 0)
      formdata.append("purchaseOrder.paidByPoints", true);
    else formdata.append("purchaseOrder.paidByPoints", false);
    for (let i = 0; i < this.state.takenSeats.length; i++) {
      formdata.append(
        `purchaseOrder.items[${i}].filmScreeningId`,
        filmScreening.filmScreeningId
      );
      formdata.append(`purchaseOrder.items[${i}].price`, prices[i]);
      formdata.append(`purchaseOrder.items[${i}].points`, points[i]);
      formdata.append(
        `purchaseOrder.items[${i}].seatSeatId`,
        this.state.takenSeats[i].seat.id
      );
      formdata.append(
        `purchaseOrder.items[${i}].seatSectionId`,
        this.state.takenSeats[i].section.id
      );
      formdata.append(
        `purchaseOrder.items[${i}].seatLevelId`,
        this.state.takenSeats[i].level.id
      );
      formdata.append(
        `purchaseOrder.items[${i}].seatRoomId`,
        this.state.takenSeats[i].room.id
      );
    }
    fetch("https://localhost:44313/api/PurchaseOrder", {
      mode: "cors",
      headers: {
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
      method: "POST",
      body: formdata,
    })
      .then((response) => {
        if (!response.ok) {
          this.setState({ error: response.status });
          throw Error(response.statusText);
        } else {
          return response.json();
        }
      })
      .then((response) => {
        purchaseOrderId = response.id;
        if (paymentMethod !== 0)
          setTimeout(() => {
            this.checkPending(purchaseOrderId);
          }, 600000);
        this.props.history.push({
          pathname: "/purchaseOrder",
          state: {
            filmScreening,
            takenSeats,
            prices,
            points,
            modifiedPrice,
            paymentMethod,
            purchaseOrderId,
            boxOffice,
          },
        });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
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
        <Row>
          <Col>
            <h4>Reserva para la película {this.state.film.film.name}</h4>
            <h6>
              {formatDateRequest(this.state.date)} - {this.state.time}
            </h6>
          </Col>
        </Row>
        <Row>
          <Col></Col>
          <Col className="center-counter" md={2}>
            <Badge variant="dark">
              Precio modificado {this.modifiedPrice()}
            </Badge>
          </Col>
          <Col className="center-counter" md={3}>
            <OverlayTrigger
              trigger="click"
              key="ticketsCard"
              placement="bottom"
              overlay={
                <Popover id="ticketsCard">
                  <Popover.Title as="h3">
                    {this.state.takenSeats.length === 0
                      ? "No se han escogido asientos."
                      : "Asientos escogidos"}
                  </Popover.Title>
                  <Popover.Content>
                    <ListGroup>
                      {this.state.takenSeats.map((item, index) => (
                        <ListGroupItem>
                          {item.room.name}-{item.level.name}-{item.section.name}
                          -{item.seat.code}
                          <Button
                            className="ml-3"
                            style={{ padding: "0px", float: "right" }}
                            onClick={() =>
                              this.handleDeleteSeat(item.seat.id, index)
                            }
                            variant="danger"
                          >
                            <TrashFill style={{ width: "100%" }} />
                          </Button>
                        </ListGroupItem>
                      ))}
                    </ListGroup>
                  </Popover.Content>
                </Popover>
              }
            >
              <Button size="lg" variant="secondary" style={{ float: "right" }}>
                <Badge variant="light">CUP: {this.totalPrice()}</Badge>
                {"  "}
                <Badge variant="light">
                  Puntos:{" "}
                  {this.state.takenSeats.length *
                    this.state.filmScreeningSelected[0].points}
                </Badge>
                {"  "}
                <Cart />
              </Button>
            </OverlayTrigger>
          </Col>
        </Row>
        <Row>
          <Col>
            <Row>
              <Form style={{ width: "100%" }} controlId="numberOfTickets">
                <Form.Row>
                  <Col>
                    <Form.Group controlId="numberOfTickets">
                      <Form.Label className="mb-0">
                        Cantidad de entradas deseadas :
                      </Form.Label>
                      <Row className="mb-3 ml-1 mt-0">
                        <small>
                          (existen {this.state.availables} disponibles)
                        </small>
                      </Row>
                      <Form.Control
                        style={{ width: "30%" }}
                        min={0}
                        max={this.state.availables}
                        onChange={this.getTickets}
                        type="number"
                      />
                    </Form.Group>
                    {(JSON.parse(
                      localStorage.getItem("loggedUser")
                    ).roles.includes("WebMaster") ||
                      JSON.parse(
                        localStorage.getItem("loggedUser")
                      ).roles.includes("Admin")) && (
                      <Form.Group controlId="numberOfTickets">
                        <Form.Label className="mb-0">Taquilla:</Form.Label>
                        <Form.Control
                          style={{ width: "30%" }}
                          onChange={this.setBoxOffice}
                          type="text"
                        />
                      </Form.Group>
                    )}
                  </Col>
                </Form.Row>
              </Form>
            </Row>
            <Row className="mt-3">
              <Container style={{ paddingLeft: "0px" }}>
                <h6>Modificaciones disponibles para el precio:</h6>
              </Container>

              <ListGroup>
                {this.state.filmScreeningSelected[0].priceModifications.map(
                  (item, index) => (
                    <ListGroupItem>
                      {item.priceModification.name}{" "}
                      <Form.Check
                        className="ml-3"
                        inline
                        id={item.priceModification.id}
                        disabled={item.optional ? false : true}
                        type="checkbox"
                        onChange={() => this.changePriceModification(index)}
                      />
                    </ListGroupItem>
                  )
                )}
              </ListGroup>
            </Row>
          </Col>
          <Col>
            <Row>
              <Col md={3}>
                <Form.Group className="mr-3 mt-5" controlId="rooms">
                  <Form.Label>Sala:</Form.Label>
                  <Form.Control
                    as="select"
                    onChange={this.onChangeSelectedRoom}
                    custom
                  >
                    {this.state.grouped
                      .map((c) => c.room)
                      .map((room) => (
                        <option id={room.id}>{room.name}</option>
                      ))}
                  </Form.Control>
                </Form.Group>
              </Col>
              <Col></Col>
              <Col md={4}>
                <Form.Group className="mr-3 mt-5 " controlId="paymentMethod">
                  <Form.Label>Seleccione el método de pago:</Form.Label>
                  <Form.Control
                    onChange={(e) => {
                      this.setState({
                        paymentMethod:
                          e.target.children[e.target.selectedIndex].id,
                      });
                    }}
                    as="select"
                    name="paymentMethod"
                  >
                    {JSON.parse(localStorage.getItem("loggedUser"))
                      .isClubMember && <option id={0}>Puntos</option>}
                    <option id={1}>Crédito</option>
                  </Form.Control>
                </Form.Group>
              </Col>
            </Row>
            <Row style={{ width: "100%" }}>
              {this.state.seats.length > 0 &&
                groupBy(this.state.seats, ["room.id", "level.id", "section.id"])
                  .filter((c) => c.room.id === this.state.selectedRoom)[0]
                  ._items.map((l) => (
                    <Row className="mt-3" style={{ width: "100%" }}>
                      <Row style={{ width: "100%" }}>
                        <h4>{l.level.name}</h4>
                      </Row>
                      <Row>
                        {l._items.map((s) => (
                          <Col style={{ width: "100%" }}>
                            <h5>{s.section.name}</h5>
                            <ListGroup>
                              {s._items.map((seat, index) => (
                                <ListGroupItem
                                  style={{ width: "200px" }}
                                  variant={
                                    seat.available ? "success" : "danger"
                                  }
                                  id={seat.seat.id}
                                >
                                  <Row>
                                    <Col md={3}>{seat.seat.code}</Col>

                                    {seat.available && (
                                      <Col>
                                        <OverlayTrigger
                                          overlay={
                                            <Tooltip id="price/points">
                                              CUP/Puntos
                                            </Tooltip>
                                          }
                                        >
                                          <span className="d-inline-block">
                                            <Button
                                              bsPrefix="transparent-button"
                                              id={seat.seat.id}
                                              size="sm"
                                            >
                                              {this.setPrice(
                                                l.level.percentOfPriceIncrement,
                                                this.state
                                                  .filmScreeningSelected[0]
                                              )}
                                              /
                                              {
                                                this.state
                                                  .filmScreeningSelected[0]
                                                  .points
                                              }
                                            </Button>
                                          </span>
                                        </OverlayTrigger>
                                      </Col>
                                    )}
                                    {seat.available && (
                                      <Col md={1}>
                                        <Button
                                          variant="success"
                                          id={seat.seat.id}
                                          size="sm"
                                          style={{ float: "right" }}
                                          onClick={(e) =>
                                            this.onSelectSeat(
                                              e,
                                              seat,
                                              this.state
                                                .filmScreeningSelected[0],
                                              l.level.percentOfPriceIncrement
                                            )
                                          }
                                        >
                                          <CartPlus id={seat.seat.id} />
                                        </Button>
                                      </Col>
                                    )}
                                  </Row>
                                </ListGroupItem>
                              ))}
                            </ListGroup>
                          </Col>
                        ))}
                      </Row>
                    </Row>
                  ))}
            </Row>
          </Col>
        </Row>
        <Row className="mt-5">
          <Col>
            <Button
              disabled={this.state.takenSeats.length > 0 ? false : true}
              style={{ float: "right" }}
              onClick={this.onFormSubmit}
            >
              Continuar
            </Button>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default withRouter(Reserve);
