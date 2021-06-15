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
  Badge,
} from "react-bootstrap";
import "./Reserve.css";
import { TrashFill, Cart, CartPlus } from "react-bootstrap-icons";
import { withRouter } from "react-router-dom";

class Reserve extends Component {
  state = {
    selectedPriceModifications: [],
    seats: [
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "2", name: "B" },
        seat: { id: "1" },
        available: false,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "2" },
        available: true,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "3" },
        available: true,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "4" },
        available: false,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "5" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "6" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "2", name: "Platea Alta", percentOfPriceIncrement: 10 },
        section: { id: "1", name: "A" },
        seat: { id: "7" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "8" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "9" },
        available: false,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja", percentOfPriceIncrement: 0 },
        section: { id: "1", name: "A" },
        seat: { id: "10" },
        available: true,
      },
    ],
    selectedRoom: undefined,
    availables: undefined,
    filmScreeningSelected: undefined,
    grouped: [],
    takenSeats: [],
    boxOffice: undefined,
  };

  componentWillMount() {
    // fetch(`https://localhost:44334/api/FilmScreening/${this.props.location.state.film[0].film.id}/
    //${ formatDateRequest(this.props.location.state.film[0].date) } /${this.props.location.state.film[0].time}`, {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ seats: response });
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
    let filmScreeningSelected = this.props.location.state.film;
    let grouped = groupBy(this.state.seats, [
      "room.id",
      "level.id",
      "section.id",
    ]);
    let selectedRoom = grouped[0].room.id;
    let selectedPriceModifications = [];
    filmScreeningSelected[0].priceModifications.forEach((element) => {
      var selected = element.optional ? false : true;
      selectedPriceModifications.push({ mod: element, selected: selected });
    });
    this.setState({
      filmScreeningSelected: filmScreeningSelected,
      film: filmScreeningSelected[0].film,
      date: filmScreeningSelected[0].date,
      time: filmScreeningSelected[0].time,
      grouped: grouped,
      selectedRoom: selectedRoom,
      selectedPriceModifications: selectedPriceModifications,
    });
  }

  componentDidMount() {
    let availables = this.state.seats.filter(
      (c) => c.available === true
    ).length;
    this.setState({
      availables: availables,
    });
  }

  onChangeSelectedRoom = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    this.setState({ selectedRoom: id });
  };

  onSelectSeat = (e, s) => {
    let seat = e.target.id;
    if (!this.state.takenSeats.map((c) => c.seat.id).includes(seat)) {
      let newSeats = [...this.state.takenSeats, s];
      this.setState({ takenSeats: newSeats });
    }
  };

  handleDeleteSeat = (idS) => {
    let newSeats = this.state.takenSeats.filter((c) => c.seat.id !== idS);
    this.setState({ takenSeats: newSeats });
  };

  getTickets = (e) => {
    let seats = this.state.seats
      .filter((c) => c.available === true)
      .slice(0, e.target.value);
    this.setState({ takenSeats: seats });
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

  onFormSubmit = (e) => {
    let filmScreening = this.state.filmScreeningSelected.filter(
      (c) => c.room.id === this.state.selectedRoom
    )[0];
    let takenSeats = this.state.takenSeats;
    this.props.history.push({
      pathname: "/purchaseOrder",
      state: { filmScreening, takenSeats },
    });
  };

  render() {
    return (
      <Container className="mt-5">
        <Row>
          <Col>
            <h4>Reserva para la película {this.state.film.name}</h4>
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
                      {this.state.takenSeats.map((item) => (
                        <ListGroupItem>
                          {item.room.name}-{item.level.name}-{item.section.name}
                          -{item.seat.id}
                          <Button
                            className="ml-3"
                            style={{ padding: "0px", float: "right" }}
                            onClick={() => this.handleDeleteSeat(item.seat.id)}
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
          {JSON.parse(localStorage.getItem("loggedUser")) &&
            (JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "Worker"
            ) ||
              JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
                "WebMaster"
              )) && (
              <Col className="center-counter" md={2}>
                <Button
                  onClick={() =>
                    this.props.history.push({
                      pathname: "/bookEntry",
                      state: this.modifiedPrice(),
                    })
                  }
                  variant="secondary"
                >
                  Agregar ingreso
                </Button>
              </Col>
            )}
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
                    <Form.Group controlId="numberOfTickets">
                      <Form.Label className="mb-0">Taquilla:</Form.Label>
                      <Form.Control
                        style={{ width: "30%" }}
                        onChange={this.setBoxOffice}
                        type="text"
                      />
                    </Form.Group>
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
            </Row>
            <Row style={{ width: "100%" }}>
              {this.state.grouped
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
                                style={{ width: "180px" }}
                                variant={seat.available ? "success" : "danger"}
                                id={seat.seat.id}
                              >
                                <Row>
                                  <Col md={1}>
                                    {seat.section.name}
                                    {index + 1}
                                  </Col>

                                  {seat.available && (
                                    <Col style={{ alignItems: "center" }}>
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
                                                .filmScreeningSelected[0].points
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
                                            this.state.filmScreeningSelected[0]
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
