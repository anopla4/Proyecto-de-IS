import React, { Component } from "react";
import {
  Card,
  FormControl,
  Row,
  Col,
  ListGroup,
  Container,
  Button,
  Popover,
  OverlayTrigger,
} from "react-bootstrap";
import "./MoviesScreening.css";
import { groupBy, onlyUnique, formatDateRequest } from "../utils";
import { Typeahead } from "react-bootstrap-typeahead";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import { withRouter } from "react-router-dom";

class MoviesScreening extends Component {
  state = {
    movies: [
      {
        id: "1",
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        time: "8:00 PM",
        room: { id: "1", name: "Sala A" },
        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
      },
      {
        id: "2",
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-06",
        time: "8:00 PM",
        room: { id: "2", name: "Sala B" },
        priceModifications: [],
      },

      {
        id: "2",
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-06",
        time: "8:00 PM",
        room: { id: "1", name: "Sala A" },
        priceModifications: [],
      },
      {
        id: "3",
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        time: "10:00 PM",
        room: { id: "2", name: "Sala B" },
        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
      },
      {
        id: "4",
        film: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
        time: "10:00 PM",
        room: { id: "2", name: "Sala B" },
      },
    ],
    moviesFilter: [
      {
        id: 1,
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        time: "8:00 PM",
        room: { id: "1", name: "Sala A" },
        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
      },
      {
        id: 2,
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-06",
        time: "8:00 PM",
        room: { id: "2", name: "Sala B" },

        priceModifications: [],
      },
      {
        id: 3,
        film: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        time: "10:00 PM",
        room: { id: "1", name: "Sala A" },

        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
      },
      {
        id: 4,
        film: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        price: 20,
        points: 20,
        date: "2021-06-05",
        time: "10:00 PM",
        room: { id: "2", name: "Sala B" },

        priceModifications: [
          {
            priceModification: {
              id: "1",
              name: "Día de las madres",
              value: 20,
              type: "Descuento",
            },
            optional: false,
          },
        ],
      },
    ],
    grouped: [],
    inputName: "",
    inputTime: "",
    inputDate: "",
  };

  componentDidMount() {
    let grouped = groupBy(this.state.movies, ["film.id", "date", "time"]);
    this.setState({ grouped: grouped });
    // fetch("https://localhost:44313/api/FilmScreening/WithTimes", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ movies: response, moviesFilter: response });
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
  }

  handleInputChangeTypeahead = (text, e) => {
    let moviesTempFilter = [...this.state.movies];
    moviesTempFilter = moviesTempFilter.filter((c) => {
      if (c.film.name.toLowerCase().match(text.toLowerCase())) return true;
      return false;
    });
    if (this.state.inputTime !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.time === this.state.inputTime) return true;
        return false;
      });
    }
    if (this.state.inputDate !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.date === this.state.inputDate) return true;
        return false;
      });
    }
    const movies = groupBy(moviesTempFilter, ["film.id", "date", "time"]);
    this.setState({
      inputName: text,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
  };

  handleChangeTypeahead = (e) => {
    let text = "";
    let moviesTempFilter = [...this.state.movies];

    if (e.length !== 0) {
      text = e[0];
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.film.name.toLowerCase().match(text.toLowerCase())) return true;
        return false;
      });
    }
    if (this.state.inputTime !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.time === this.state.inputTime) return true;
        return false;
      });
    }
    if (this.state.inputDate !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.date === this.state.inputDate) return true;
        return false;
      });
    }
    const movies = groupBy(moviesTempFilter, ["film.id", "date", "time"]);
    this.setState({
      inputName: text,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
  };

  handleChangeTime = (e) => {
    let time = e.target.value;
    let moviesTempFilter = [...this.state.movies];
    if (time !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.time === time) return true;
        return false;
      });
    }
    if (this.state.inputName !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.film.name.toLowerCase().match(this.state.inputName.toLowerCase()))
          return true;
        return false;
      });
    }
    if (this.state.inputDate !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.date === this.state.inputDate) return true;
        return false;
      });
    }
    const movies = groupBy(moviesTempFilter, ["film.id", "date", "time"]);
    this.setState({
      inputTime: time,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
  };

  handleChangeDate = (e) => {
    let date = e.target.value;
    let moviesTempFilter = [...this.state.movies];
    if (date !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.date === date) return true;
        return false;
      });
    }
    if (this.state.inputName !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.film.name.toLowerCase().match(this.state.inputName.toLowerCase()))
          return true;
        return false;
      });
    }
    if (this.state.inputTime !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.time === this.state.inputTime) return true;
        return false;
      });
    }
    const movies = groupBy(moviesTempFilter, ["film.id", "date", "time"]);
    this.setState({
      inputDate: date,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
  };

  handleOnEdit = (a) => {
    let filmScreenings = [];
    a.forEach((element) => {
      element.forEach((d) => {
        filmScreenings.push(d);
      });
    });
    console.log(filmScreenings);
    let roomTimes = [];
    let date = filmScreenings[0].date;
    let film = filmScreenings[0].film;
    let price = filmScreenings[0].price;
    let points = filmScreenings[0].points;
    let priceModifications = filmScreenings[0].priceModifications;
    filmScreenings.forEach((element) => {
      roomTimes.push({ room: element.room, time: element.time });
    });
    console.log(filmScreenings);
    this.props.history.push({
      pathname: "/filmScreeningForm",
      state: {
        date: date,
        film: film,
        price: price,
        points: points,
        roomTimes: roomTimes,
        selectedPriceMod: priceModifications,
      },
    });
  };

  reserve = (film) => {
    this.props.history.push({ pathname: "/reserve", state: { film } });
  };

  render() {
    return (
      <Container>
        <Row>
          <Col md={8}>
            {this.state.grouped.map((item) => (
              <Card className="mb-3">
                <Row>
                  <Col md={3}>
                    <Card.Img
                      fluid
                      variant="top"
                      src={`http://localhost:8000/${item.film.imgPath}`}
                    />
                  </Col>
                  <Col>
                    <Card.Body>
                      <Card.Title>
                        {item.film.name} ({item.film.year})
                      </Card.Title>
                      <Card.Subtitle>
                        Género: {item.film.genre.name}
                      </Card.Subtitle>
                    </Card.Body>
                    {item._items.map((date) => (
                      <ListGroup
                        key={item.film.id}
                        className="list-group-flush"
                      >
                        <Row>
                          <Col md={1} style={{ padding: "0px" }}>
                            <DeleteEdit
                              edit={true}
                              onEdit={() =>
                                this.handleOnEdit(
                                  date._items.map((c) => c._items)
                                )
                              }
                            />
                          </Col>
                          <Col md={4}>
                            <OverlayTrigger
                              key={`priceMod-${item.film.id}-${date.date}`}
                              placement="top"
                              overlay={
                                <Popover
                                  id={`priceMod-${item.film.id}-${date.date}`}
                                >
                                  <Popover.Title as="h3">
                                    {date._items[0]._items[0].priceModifications
                                      .length > 0
                                      ? "Modificaciones del precio disponibles"
                                      : "No hay modificaciones del precio disponibles"}
                                  </Popover.Title>
                                  {date._items[0]._items[0].priceModifications.map(
                                    (mod) => (
                                      <Popover.Content>
                                        <strong>
                                          {mod.priceModification.name}
                                        </strong>{" "}
                                        {mod.optional
                                          ? "Opcional"
                                          : "No opcional"}
                                      </Popover.Content>
                                    )
                                  )}
                                </Popover>
                              }
                            >
                              <Button variant="light">{date.date}</Button>
                            </OverlayTrigger>
                          </Col>
                          <Col>
                            <Container
                              style={{ width: "100%" }}
                              className="center-date"
                            >
                              {date._items.map((time) => (
                                <Button
                                  onClick={() => this.reserve(time._items)}
                                  variant="default"
                                  bsPrefix="my-button"
                                  className="my-button mb-2 ml-2"
                                >
                                  {time.time}
                                </Button>
                              ))}
                            </Container>
                          </Col>
                        </Row>
                      </ListGroup>
                    ))}
                  </Col>
                </Row>
              </Card>
            ))}
          </Col>
          <Col>
            <Typeahead
              onInputChange={this.handleInputChangeTypeahead}
              onChange={this.handleChangeTypeahead}
              className="mb-5"
              style={{ width: "90%", float: "right" }}
              clearButton
              id="selections-example"
              options={this.state.movies
                .map((item) => item.film)
                .map((item) => item.name)
                .filter(onlyUnique)}
              placeholder="Elija una película..."
            />
            <FormControl
              onChange={this.handleChangeTime}
              className="mb-5"
              as="select"
              style={{ width: "90%", float: "right" }}
            >
              <option id={-1}></option>
              {this.state.movies
                .map((item) => item.time)
                .filter(onlyUnique)
                .map((time) => (
                  <option id={time}>{time}</option>
                ))}
            </FormControl>
            <FormControl
              onChange={this.handleChangeDate}
              type="date"
              style={{ width: "90%", float: "right" }}
            />
          </Col>
        </Row>
      </Container>
    );
  }
}

export default withRouter(MoviesScreening);
