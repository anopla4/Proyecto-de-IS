import React, { Component } from "react";
import {
  Card,
  FormControl,
  Row,
  Col,
  ListGroup,
  Container,
  Button,
} from "react-bootstrap";
import "./MoviesScreening.css";
import { groupBy, onlyUnique, formatDate } from "../utils";
import { Typeahead } from "react-bootstrap-typeahead";

class MoviesScreening extends Component {
  state = {
    movies: [
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "05/06/2021",
        time: "8:00",
      },
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "06/06/2021",
        time: "8:00",
      },
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "05/06/2021",
        time: "10:00",
      },
      {
        movie: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        date: "05/06/2021",
        time: "10:00",
      },
    ],
    moviesFilter: [
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "05/06/2021",
        time: "8:00",
      },
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "06/06/2021",
        time: "8:00",
      },
      {
        movie: {
          id: 1,
          name: "Cinema Paradiso",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/cinemaParadiso.jpg",
        },
        date: "05/06/2021",
        time: "10:00",
      },
      {
        movie: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        date: "05/06/2021",
        time: "10:00",
      },
    ],
    grouped: [],
    inputName: "",
    inputTime: "",
    inputDate: "",
  };

  componentDidMount() {
    let grouped = groupBy(this.state.movies, ["movie.id", "date"]);
    this.setState({ grouped: grouped });
    // fetch("https://localhost:44334/api/FilmScreening/WithTimes", {
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
      if (c.movie.name.toLowerCase().match(text.toLowerCase())) return true;
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
    const movies = groupBy(moviesTempFilter, ["movie.id", "date"]);
    console.log(text);
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
        if (c.movie.name.toLowerCase().match(text.toLowerCase())) return true;
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
    const movies = groupBy(moviesTempFilter, ["movie.id", "date"]);
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
        if (
          c.movie.name.toLowerCase().match(this.state.inputName.toLowerCase())
        )
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
    const movies = groupBy(moviesTempFilter, ["movie.id", "date"]);
    this.setState({
      inputTime: time,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
  };

  handleChangeDate = (e) => {
    console.log(e.target.value);
    let date = formatDate(e.target.value);
    let moviesTempFilter = [...this.state.movies];
    if (date !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (c.date === date) return true;
        return false;
      });
    }
    if (this.state.inputName !== "") {
      moviesTempFilter = moviesTempFilter.filter((c) => {
        if (
          c.movie.name.toLowerCase().match(this.state.inputName.toLowerCase())
        )
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
    const movies = groupBy(moviesTempFilter, ["movie.id", "date"]);
    this.setState({
      inputDate: date,
      moviesFilter: moviesTempFilter,
      grouped: movies,
    });
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
                      src={`http://localhost:8000/${item.movie.imgPath}`}
                    />
                  </Col>
                  <Col>
                    <Card.Body>
                      <Card.Title>
                        {item.movie.name} ({item.movie.year})
                      </Card.Title>
                      <Card.Subtitle>
                        Género: {item.movie.genre.name}
                      </Card.Subtitle>
                    </Card.Body>
                    {item._items.map((date) => (
                      <ListGroup
                        key={item.movie.id}
                        className="list-group-flush"
                      >
                        <Row>
                          <Col md={3} style={{ margin: "10px" }}>
                            <h6 className="center-date">{date.date}</h6>
                          </Col>
                          <Col>
                            <Container
                              style={{ width: "100%", marginTop: "10px" }}
                              className="center-date"
                            >
                              {date._items.map((time) => (
                                <Button
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
                .map((item) => item.movie)
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

export default MoviesScreening;
