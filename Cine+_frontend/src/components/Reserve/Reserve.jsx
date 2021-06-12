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
} from "react-bootstrap";
import { TrashFill, Cart } from "react-bootstrap-icons";
import { withRouter } from "react-router-dom";

class Reserve extends Component {
  state = {
    selectedPriceModifications: [],
    seats: [
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "2", name: "B" },
        seat: { id: "1" },
        available: false,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "2" },
        available: true,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "3" },
        available: true,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "4" },
        available: false,
      },
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "5" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "6" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "2", name: "Platea Alta" },
        section: { id: "1", name: "A" },
        seat: { id: "7" },
        available: false,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "8" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "9" },
        available: false,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
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
    this.setState({
      filmScreeningSelected: filmScreeningSelected,
      film: filmScreeningSelected[0].film,
      date: filmScreeningSelected[0].date,
      time: filmScreeningSelected[0].time,
      grouped: grouped,
      selectedRoom: selectedRoom,
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

  onFormSubmit = () => {
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
        <h4>Reserva para la película {this.state.film.name}</h4>
        <h6>
          {formatDateRequest(this.state.date)} - {this.state.time}
        </h6>
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
                      {item.room.name}-{item.level.name}-{item.section.name}-
                      {item.seat.id}
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
            <Cart />
          </Button>
        </OverlayTrigger>
        <Row>
          <Col>
            <Row>
              <Form
                style={{ width: "100%" }}
                className="mt-5"
                controlId="numberOfTickets"
              >
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
                  </Col>
                  {/* <Col style={{ display: "flex", alignItems: "center" }}>
                    <Button type="submit">Aceptar</Button>
                  </Col> */}
                </Form.Row>
              </Form>
            </Row>
            <Row className="mt-3">
              <Container style={{ paddingLeft: "0px" }}>
                <h6>Modificaciones disponibles para el precio:</h6>
              </Container>

              <ListGroup>
                {this.state.filmScreeningSelected[0].priceModifications.map(
                  (item) => (
                    <ListGroupItem>
                      {item.priceModification.name}{" "}
                      <Form.Check
                        className="ml-3"
                        inline
                        id={item.priceModification.id}
                        disabled={item.optional ? false : true}
                        type="checkbox"
                      ></Form.Check>
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
                                style={{ width: "150px" }}
                                variant={seat.available ? "success" : "danger"}
                                id={seat.seat.id}
                              >
                                {seat.section.name}
                                {index + 1}
                                {seat.available && (
                                  <Button
                                    variant="success"
                                    id={seat.seat.id}
                                    size="sm"
                                    style={{ float: "right" }}
                                    onClick={(e) => this.onSelectSeat(e, seat)}
                                  >
                                    Pick
                                  </Button>
                                )}
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
