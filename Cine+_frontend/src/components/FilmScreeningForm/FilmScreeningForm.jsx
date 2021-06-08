import React, { Component } from "react";
import {
  Container,
  Col,
  Form,
  Row,
  ListGroup,
  ListGroupItem,
  Button,
} from "react-bootstrap";
import { TrashFill } from "react-bootstrap-icons";
import Add from "../Add/Add";

class FilmScreeningForm extends Component {
  state = {
    films: [],
    genres: [],
    times: [],
    roomTimes: [],
    selectedRooms: [],
  };

  componentWillMount() {
    // fetch("https://localhost:44334/api/Film", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ films: response});
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
    let t = [
      "1:00",
      "2:00",
      "3:00",
      "4:00",
      "5:00",
      "6:00",
      "7:00",
      "8:00",
      "9:00",
      "10:00",
      "11:00",
      "12:00",
      "1:00",
    ];
    this.setState({ times: t });
  }

  render() {
    return (
      <Container>
        <h1 className="mb-5 my-style-header">Puesta en escena</h1>
        <Row alignSelf="center" className="mt-4">
          <Col className="center">
            <Form
              onSubmit={this.onFormSubmit}
              style={{ width: "100%", alignItems: "center" }}
            >
              <Row>
                <Col>
                  <Form.Group style={{ width: "100%" }} controlId="date">
                    <Form.Label>Fecha:</Form.Label>
                    <Form.Control type="date" />
                  </Form.Group>
                </Col>
                <Col>
                  <Form.Group controlId="time">
                    <Form.Label>Horas:</Form.Label>
                    <Form.Control as="select" custom>
                      <option>{""}</option>
                      {this.state.times.map((time) => (
                        <option id={time}>{time}</option>
                      ))}
                    </Form.Control>
                  </Form.Group>
                </Col>
                <Col md={1}>
                  <Form.Group controlId="s">
                    <Form.Label></Form.Label>
                    <Form.Control as="select" custom>
                      <option>{""}</option>
                      <option id={"AM"}>{"AM"}</option>
                      <option id={"PM"}>{"PM"}</option>
                    </Form.Control>
                  </Form.Group>
                </Col>
              </Row>
              <Row>
                <Col>
                  <Form.Group controlId="film">
                    <Form.Label>Película:</Form.Label>
                    <Form.Control as="select" custom>
                      <option>{""}</option>
                      {this.state.films.map((film) => (
                        <option id={film.id}>{film.name}</option>
                      ))}
                    </Form.Control>
                  </Form.Group>
                </Col>
                <Col>
                  <Row>
                    <Form.Group controlId="genres">
                      <Form.Label>Salas:</Form.Label>
                      <Form.Control
                        as="select"
                        onChange={this.addNewRoom}
                        custom
                      >
                        <option>{""}</option>
                        {this.state.rooms.map((room) => (
                          <option id={room.id}>{room.name}</option>
                        ))}
                      </Form.Control>
                    </Form.Group>
                  </Row>
                  <Row md={1} style={{ marginTop: "30px" }}>
                    <Add
                      className="btnFormSend "
                      variant="outline-secondary"
                      onClick={this.handleAddRoom}
                    />
                  </Row>
                  <Row>
                    <ListGroup style={{ marginTop: "20px" }}>
                      {this.state.selectedRooms.map((room, index) => (
                        <ListGroupItem>
                          {room.name}
                          {
                            // isLoggedIn() &&
                            <Button
                              className="ml-3"
                              style={{ padding: "0px", float: "right" }}
                              onClick={() => this.handleDeleteGenre(room.id)}
                              variant="danger"
                            >
                              <TrashFill style={{ width: "100%" }} />
                            </Button>
                          }
                        </ListGroupItem>
                      ))}
                    </ListGroup>
                  </Row>
                </Col>
              </Row>
            </Form>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default FilmScreeningForm;
