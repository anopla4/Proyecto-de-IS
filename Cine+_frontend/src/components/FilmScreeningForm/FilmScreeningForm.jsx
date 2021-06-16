import React, { Component } from "react";
import {
  Container,
  Col,
  Form,
  Row,
  ListGroup,
  ListGroupItem,
  Button,
  Toast,
} from "react-bootstrap";
import { TrashFill } from "react-bootstrap-icons";
import Add from "../Add/Add";
import { formatDate } from "../utils";

class FilmScreeningForm extends Component {
  state = {
    // films: [],
    films: [
      {
        film: {
          id: 1,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
          genres: [{ name: "Thriller" }],
        },
        staff: [
          { rol: { name: "Actor" }, member: "John Travolta" },
          { rol: { name: "Director" }, member: "Quentin Tarantino" },
        ],
      },
      {
        film: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
          genres: [{ name: "Thriller" }],
        },
        staff: [
          { rol: { name: "Actor" }, member: "John Travolta" },
          { rol: { name: "Director" }, member: "Quentin Tarantino" },
        ],
      },
    ],
    times: [],
    rooms: [
      { id: "1", name: "Sala A" },
      { id: "2", name: "Sala B" },
    ],
    priceModifications: [
      {
        id: "1",
        name: "Día de las madres",
        type: "Descuento",
        value: 50,
        description:
          "Por el día de las madres el cine hará un descuento para todas las personas",
      },
    ],
    edit: false,
    selectedPriceMod: [],
    roomTimes: [],
    showToast: false,
    newRoom: undefined,
    time: undefined,
    newMod: undefined,
    addNewMod: false,
    AM_PM: "AM",
    optional: false,
  };

  componentWillMount() {
    // fetch("https://localhost:44313/api/Film", {
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
    // fetch("https://localhost:44313/api/Room", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ rooms: response});
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
    // fetch("https://localhost:44313/api/PriceModification", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ priceModifications: response});
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
    ];
    if (this.props.location.state.roomTimes !== undefined) {
      let roomTimes = this.props.location.state.roomTimes;
      //   let date = this.props.location.state.date;
      // let film = this.props.location.state.date;
      let selectedPriceMod = this.props.location.state.selectedPriceMod;
      this.setState({
        times: t,
        roomTimes: roomTimes,
        selectedPriceMod: selectedPriceMod,
        edit: true,
      });
    } else {
      this.setState({ times: t });
    }
  }

  handleShowToast = () => {
    this.setState({ showToast: true });
  };

  handleCloseToast = () => {
    this.setState({ showToast: false });
  };

  addNewRoom = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    this.setState({ newRoom: id });
  };

  addNewTime = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    let s = this.state.AM_PM;
    this.setState({ time: id + " " + s });
  };

  addAMPM = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    let a = this.state.time.split(" ");
    let newTime = a[0] + " " + id;
    this.setState({
      time: newTime,
      AM_PM: id,
    });
  };

  onChangeOptional = (e) => {
    this.setState({ optional: !this.state.optional });
  };

  addMod = (e) => {
    let id = e.target.children[e.target.selectedIndex].id;
    this.setState({ newMod: id });
  };

  addNewMod = () => {
    this.setState({ addNewMod: true });
  };

  handleAddRoom = () => {
    let room = this.state.newRoom;
    let time = this.state.time;
    if (room && time) {
      let element = this.state.roomTimes
        .map((room) => room.room)
        .find((c) => c.id === room);
      if (element) {
        let oldTime = this.state.roomTimes
          .filter((c) => c.room.id === room)
          .map((s) => s.time);
        if (!oldTime.includes(time)) {
          let newR = this.state.rooms.find((c) => c.id === room);
          let item = { room: newR, time: time };
          let newRooms = [...this.state.roomTimes, item];
          this.setState({ roomTimes: newRooms });
        } else {
          this.handleShowToast();
        }
      } else {
        let newR = this.state.rooms.find((c) => c.id === room);
        let item = { room: newR, time: time };
        let newRooms = [...this.state.roomTimes, item];
        this.setState({ roomTimes: newRooms });
      }
    }
  };

  handleAddMod = () => {
    let mod = this.state.newMod;
    let opt = this.state.optional;
    if (mod) {
      let element = this.state.priceModifications.find((c) => c.id === mod);
      if (element) {
        let oldMod = this.state.selectedPriceMod.find((c) => c.mod.id === mod);

        if (!oldMod || oldMod.mod.id !== mod) {
          let newM = this.state.priceModifications.find((c) => c.id === mod);
          let item = { priceModification: newM, optional: opt };
          let newMods = [...this.state.selectedPriceMod, item];
          this.setState({ selectedPriceMod: newMods });
        }
      } else {
        let newM = this.state.priceModifications.find((c) => c.id === mod);
        let item = { priceModification: newM, optional: opt };
        let newMods = [...this.state.selectedPriceMod, item];
        this.setState({ selectedPriceMod: newMods });
      }
    }
  };

  handleAddNewMod = (e) => {
    let formElements = e.target.elements;
    const name = formElements.name.value;
    const description = formElements.description.value;
    const value = formElements.value.value;
    const type = e.target.options.selectedIndex;
    let mod = {
      name,
      description,
      value,
      type,
    };
    // fetch("https://localhost:44313/api/PriceModification", {
    //   mode: "cors",
    //   headers: {
    //     "Content-Type": "application/json",
    //     Authorization:
    //       "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
    //   },
    //   method: "POST",
    //   body: JSON.stringify(mod),
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
    this.setState({ addNewMod: false });
  };

  handleDeleteRoom = (room, index) => {
    let newRooms = this.state.roomTimes.filter(
      (c) => c.room.id !== room.room.id || c.time !== room.time
    );
    this.setState({ roomTimes: newRooms });
  };

  handleDeleteMod = (mod, index) => {
    let newMods = this.state.selectedPriceMod.filter((c) => c.id !== mod.id);
    this.setState({ selectedPriceMod: newMods });
  };

  onFormSubmit = (e) => {
    let formElements = e.target.elements;
    const price = formElements.price.value;
    const points = formElements.points.value;
    let filmId = this.props.location.state.film.id;
    let date = this.props.location.state.date;
    const roomTimes = this.state.roomTimes;
    const priceModifications = this.state.selectedPriceMod;

    if (!this.state.edit) {
      const film = formElements.film;
      filmId = film.children[film.selectedIndex].id;
      date = formElements.date.value;
    }
    let item = {
      filmId,
      date,
      price,
      points,
      roomTimes,
      priceModifications,
    };
    let postUrl =
      "https://localhost:44313/api/FilmScreening" +
      (this.state.edit ? `/${this.state.filmId}/${date}` : "");
    // fetch(postUrl, {
    //   mode: "cors",
    //    headers: { "Content-Type": "application/json","Authorization": "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token },
    //method: this.state.edit ? "PATCH" : "POST",
    //   body: {item},
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
    this.props.history.push({
      pathname: "/filmScreenings",
      state: { edited: true },
    });
  };

  render() {
    return (
      <Container className="mt-5">
        <h1 className="mb-5 my-style-header">Puesta en escena</h1>
        <Row alignSelf="center" className="mt-4">
          <Col className="center">
            <Form
              onSubmit={this.onFormSubmit}
              style={{ width: "100%", alignItems: "center" }}
            >
              <Row>
                <Col>
                  {this.props.location.state.film ? (
                    <Container>
                      <h5>Película:</h5>
                      <h6>{this.props.location.state.film.name}</h6>
                    </Container>
                  ) : (
                    <Form.Group controlId="film">
                      <Form.Label>Película:</Form.Label>
                      <Form.Control as="select" custom>
                        <option>{""}</option>
                        {this.state.films.map((film) => (
                          <option id={film.film.id}>{film.film.name}</option>
                        ))}
                      </Form.Control>
                    </Form.Group>
                  )}
                </Col>
                <Col>
                  {this.props.location.state.date ? (
                    <Container>
                      <h5>Fecha:</h5>
                      <h6>{this.props.location.state.date}</h6>
                    </Container>
                  ) : (
                    <Form.Group style={{ width: "100%" }} controlId="date">
                      <Form.Label>Fecha:</Form.Label>
                      <Form.Control type="date" />
                    </Form.Group>
                  )}
                </Col>
                <Col md={2}>
                  <Form.Group style={{ width: "100%" }} controlId="price">
                    <Form.Label>Precio:</Form.Label>
                    <Form.Control
                      defaultValue={
                        this.props.location.state.price
                          ? this.props.location.state.price
                          : 0
                      }
                      min={0}
                      type="number"
                    />
                  </Form.Group>
                </Col>
                <Col md={2}>
                  <Form.Group style={{ width: "100%" }} controlId="points">
                    <Form.Label>Puntos:</Form.Label>
                    <Form.Control
                      defaultValue={
                        this.props.location.state.points
                          ? this.props.location.state.points
                          : 0
                      }
                      min={0}
                      type="number"
                    />
                  </Form.Group>
                </Col>
              </Row>
              <Row>
                <Col md={3}>
                  <Form.Group className="mr-3" controlId="genres">
                    <Form.Label>Sala:</Form.Label>
                    <Form.Control as="select" onChange={this.addNewRoom} custom>
                      <option>{""}</option>
                      {this.state.rooms.map((room) => (
                        <option id={room.id}>{room.name}</option>
                      ))}
                    </Form.Control>
                  </Form.Group>
                </Col>
                <Col md={2}>
                  <Form.Group controlId="time">
                    <Form.Label>Hora:</Form.Label>
                    <Form.Control onChange={this.addNewTime} as="select" custom>
                      <option>{""}</option>
                      {this.state.times.map((time) => (
                        <option id={time}>{time}</option>
                      ))}
                    </Form.Control>
                  </Form.Group>
                </Col>
                <Col md={2}>
                  <Form.Group controlId="s">
                    <Form.Label>AM/PM:</Form.Label>
                    <Form.Control onChange={this.addAMPM} as="select" custom>
                      <option id={"AM"}>{"AM"}</option>
                      <option id={"PM"}>{"PM"}</option>
                    </Form.Control>
                  </Form.Group>
                </Col>
                <Col md={1} style={{ paddingTop: "31px" }}>
                  <Add
                    variant="outline-secondary"
                    onClick={this.handleAddRoom}
                  />
                </Col>
                <Col>
                  <ListGroup style={{ marginTop: "20px" }}>
                    {this.state.roomTimes.map((room, index) => (
                      <ListGroupItem>
                        {room.room.name}-{room.time}
                        {
                          // isLoggedIn() &&
                          <Button
                            className="ml-3"
                            style={{ padding: "0px", float: "right" }}
                            onClick={() => this.handleDeleteRoom(room, index)}
                            variant="danger"
                          >
                            <TrashFill style={{ width: "100%" }} />
                          </Button>
                        }
                      </ListGroupItem>
                    ))}
                  </ListGroup>
                </Col>
                <Toast
                  show={this.state.showToast}
                  onClose={this.handleCloseToast}
                >
                  <Toast.Header>
                    <strong className="mr-auto">¡Atención!</strong>
                  </Toast.Header>
                  <Toast.Body>
                    Ya existe una puesta en escena en esta sala y a esta hora.
                  </Toast.Body>
                </Toast>
              </Row>
              <Row>
                <Col>
                  <Row>
                    <Form.Group
                      onChange={this.addMod}
                      controlId="priceModification"
                    >
                      <Form.Label>
                        Posibles modificaciones para el precio de una entrada:
                      </Form.Label>
                      <Form.Control as="select" custom>
                        <option>{""}</option>
                        {this.state.priceModifications.map((mod) => (
                          <option id={mod.id}>{mod.name}</option>
                        ))}
                      </Form.Control>
                    </Form.Group>
                  </Row>
                  <Row>
                    {!this.state.addNewMod && (
                      <Add
                        text=" Agregar modificación"
                        onClick={this.addNewMod}
                      />
                    )}
                    {this.state.addNewMod && (
                      <Form
                        style={{ width: "100%" }}
                        onSubmit={this.handleAddNewMod}
                      >
                        <Form.Label>
                          <h6>Agregue la nueva modificación</h6>
                        </Form.Label>

                        <Form.Group controlId="name">
                          <Form.Label>Nombre:</Form.Label>
                          <Form.Control type="text" />
                        </Form.Group>
                        <Form.Group controlId="type">
                          <Form.Label>Tipo:</Form.Label>
                          <Form.Control as="select" custom>
                            <option id={"Descuento"}>Descuento</option>
                            <option id={"Aumento"}>Aumento</option>
                          </Form.Control>
                        </Form.Group>
                        <Form.Group controlId="value">
                          <Form.Label>Valor (en por ciento):</Form.Label>
                          <Form.Control type="number" min={0} max={100} />
                        </Form.Group>
                        <Form.Group controlId="description">
                          <Form.Label>Descripción:</Form.Label>
                          <Form.Control as="textarea" rows={3} />
                        </Form.Group>
                        <Button type="submit">Aceptar</Button>
                      </Form>
                    )}
                  </Row>
                </Col>
                <Col md={2}>
                  <Form.Label>Opcional</Form.Label>
                  <Form.Check
                    onChange={this.onChangeOptional}
                    type="checkbox"
                    id="optional"
                  />
                </Col>
                <Col md={1} style={{ paddingTop: "31px" }}>
                  <Add
                    variant="outline-secondary"
                    onClick={this.handleAddMod}
                  />
                </Col>
                <Col>
                  <ListGroup style={{ marginTop: "20px" }}>
                    {this.state.selectedPriceMod.map((mod, index) => (
                      <ListGroupItem>
                        {mod.priceModification.name} (
                        {mod.optional ? "Opcional" : "No opcional"})
                        {
                          // isLoggedIn() &&
                          <Button
                            className="ml-3"
                            style={{ padding: "0px", float: "right" }}
                            onClick={() => this.handleDeleteMod(mod, index)}
                            variant="danger"
                          >
                            <TrashFill style={{ width: "100%" }} />
                          </Button>
                        }
                      </ListGroupItem>
                    ))}
                  </ListGroup>
                </Col>
              </Row>
              <Button
                style={{ float: "right" }}
                variant="primary"
                type="submit"
                className="mt-3"
              >
                Aceptar
              </Button>
            </Form>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default FilmScreeningForm;
