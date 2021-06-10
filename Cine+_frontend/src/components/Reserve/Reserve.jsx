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
} from "react-bootstrap";

class Reserve extends Component {
  state = {
    selectedPriceModifications: [],
    seats: [
      {
        room: { id: "1", name: "Sala A" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
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
        seat: { id: "1" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "2" },
        available: false,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "3" },
        available: true,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "4" },
        available: false,
      },
      {
        room: { id: "2", name: "Sala B" },
        level: { id: "1", name: "Platea Baja" },
        section: { id: "1", name: "A" },
        seat: { id: "5" },
        available: true,
      },
    ],
    selectedRoom: undefined,
    availables: undefined,
    filmScreeningSelected: undefined,
    grouped: [],
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
    this.setState({
      filmScreeningSelected: filmScreeningSelected,
      film: filmScreeningSelected[0].film.name,
      date: filmScreeningSelected[0].date,
      time: filmScreeningSelected[0].time,
    });
  }

  componentDidMount() {
    let grouped = groupBy(this.state.seats, [
      "room.id",
      "level.id",
      "section.id",
    ]);
    let availables = this.state.seats.filter(
      (c) => c.available === true
    ).length;
    let selectedRoom = grouped[0].room.id;
    this.setState({
      availables: availables,
      grouped: grouped,
      selectedRoom: selectedRoom,
    });
  }

  onChangeSelectedRoom = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    this.setState({ selectedRoom: id });
  };

  onFormSubmit = () => {};

  render() {
    console.log(this.state.selectedRoom);
    return (
      <Container className="mt-5">
        <h4>Reserva para la película {this.state.film}</h4>
        <h6>
          {formatDateRequest(this.state.date)} - {this.state.time}
        </h6>
        <Row>
          <Col>
            <Row>
              <Form
                style={{ width: "100%" }}
                className="mt-5"
                onSubmit={this.onFormSubmit}
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
                        style={{ width: "50%" }}
                        min={0}
                        max={this.state.availables}
                        type="number"
                      />
                    </Form.Group>
                  </Col>
                  <Col style={{ display: "flex", alignItems: "center" }}>
                    <Button type="submit">Aceptar</Button>
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
              <Form.Group className="mr-3" controlId="genres">
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
              {this.state.grouped
                .filter((c) => c.room.id === this.state.selectedRoom)
                ._items.map((item) => (
                  <p>ana</p>

                  // {/* <Row>
                  // {item._items.map((l) => (

                  //   ))}
                  // </Row> */}
                ))}
            </Row>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default Reserve;
