import React, { Component } from "react";
import {
  Container,
  Card,
  Row,
  Col,
  Collapse,
  Button,
  ListGroupItem,
  CardDeck,
  ListGroup,
  OverlayTrigger,
  Tooltip,
} from "react-bootstrap";
import "../../containers/App/App.css";
import "./Films.css";
import Add from "../Add/Add";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import ReactStars from "react-rating-stars-component";
import { ThreeDots, Star } from "react-bootstrap-icons";
import "./Films.css";
import { isLoggedIn } from "../utils";

class Films extends Component {
  state = {
    filmsRated: [],
    ratings: [],
    films: [],
    filmsExpanded: [],
  };

  componentDidMount() {
    fetch("https://localhost:44313/api/Film/staff", {
      mode: "cors",
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        let expanded = response.map((film) => false);
        this.setState({ films: response, filmsExpanded: expanded });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
    if (isLoggedIn()) {
      fetch(
        `https://localhost:44313/api/UserFilm/${
          JSON.parse(localStorage.getItem("loggedUser")).userId
        }`,
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
          this.setState({ ratings: response });
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
    }
  }
  handleAdd = () => {
    this.props.history.push({ pathname: "/filmForm", state: {} });
  };

  addRated = (newRate, idF) => {
    let film = this.state.filmsRated.find((c) => c.id === idF);
    let temp = [...this.state.filmsRated];
    let rate = this.state.ratings.find((c) => c.film.id === idF);

    if (film) {
      let index = temp.indexOf(film);
      if (rate === newRate) temp = temp.filter((c) => c.id !== idF);
      else temp[index].rate = newRate;
    } else {
      temp = [...temp, { id: idF, rate: newRate }];
    }
    this.setState({ filmsRated: temp });
  };

  handleAddRatings = () => {
    this.state.filmsRated.forEach((element) => {
      var formdata = new FormData();
      formdata.append("filmId", element.id);
      formdata.append(
        "userId",
        JSON.parse(localStorage.getItem("loggedUser")).userId
      );
      formdata.append("rating", element.rate);

      let postUrl = `https://localhost:44313/api/UserFilm`;
      fetch(postUrl, {
        mode: "cors",
        headers: {
          Authorization:
            "Bearer " +
            JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
        },
        method: "POST",
        body: formdata,
      })
        .then((response) => {
          if (!response.ok) {
            throw Error(response.statusText);
          }
          return response.json();
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
    });
  };

  handleOnDelete = (id, index) => {
    fetch(`https://localhost:44313/api/Film/${id}`, {
      mode: "cors",
      method: "DELETE",
      headers: {
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
      },
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
    let n_films = [...this.state.films];
    let n_expanded = [...this.state.filmsExpanded];
    n_films.splice(index, 1);
    n_expanded.splice(index, 1);
    this.setState({ films: n_films, filmsExpanded: n_expanded });
  };

  handleOnEdit = (film) => {
    this.props.history.push({ pathname: "/filmForm", state: { film: film } });
  };

  render() {
    return (
      <Row className="mt-5">
        <Col>
          <CardDeck>
            {this.state.films.map((film, index) => (
              <Col md={3}>
                <Card className="mb-3">
                  <Row className="justify-content-center">
                    <ReactStars
                      value={
                        isLoggedIn() &&
                        this.state.ratings.find(
                          (c) => c.film.id === film.film.id
                        )
                          ? this.state.ratings.find(
                              (c) => c.film.id === film.film.id
                            ).rating
                          : 0
                      }
                      count={5}
                      onChange={(newRate) =>
                        this.addRated(newRate, film.film.id)
                      }
                      size={24}
                      activeColor="#ffd700"
                    />
                  </Row>

                  <Card.Img
                    variant="top"
                    src={`https://localhost:44313/${film.film.imgPath}`}
                  />
                  <Card.Body
                    style={{ paddingLeft: "2px", paddingRight: "2px" }}
                  >
                    <Card.Text>
                      <Container>
                        <p style={{ display: "inline" }} className="bold">
                          {film.film.name}
                        </p>
                      </Container>
                      <Container>
                        <p style={{ display: "inline" }} className="bold">
                          Géneros:{" "}
                        </p>
                        {film.genres.map((genre) => genre.name).join(", ")}.
                      </Container>
                      <Button
                        size="sm"
                        onClick={() => {
                          let copy = [...this.state.filmsExpanded];
                          copy[index] = !copy[index];
                          this.setState({ filmsExpanded: copy });
                        }}
                        style={{ float: "right" }}
                        bsPrefix="three-dots"
                        aria-controls="example-collapse-text"
                        aria-expanded={this.state.filmsExpanded[index]}
                      >
                        <ThreeDots />
                      </Button>
                      <Collapse in={this.state.filmsExpanded[index]}>
                        <ListGroup style={{ width: "100%" }}>
                          {film.staff.map((member) => (
                            <ListGroupItem>
                              <p style={{ display: "inline" }} className="bold">
                                {member.rol.name}:{" "}
                              </p>
                              {member.member}.
                            </ListGroupItem>
                          ))}
                        </ListGroup>
                      </Collapse>

                      <DeleteEdit
                        onDelete={() =>
                          this.handleOnDelete(film.film.id, index)
                        }
                        onEdit={() => this.handleOnEdit(film)}
                        delete={true}
                        edit={true}
                      />
                    </Card.Text>
                  </Card.Body>
                </Card>
              </Col>
            ))}
          </CardDeck>
        </Col>
        <Col md={1}>
          <Row>
            <OverlayTrigger
              key="moviesRate"
              placement="top"
              overlay={<Tooltip id={`moviesRate`}>Evaluar películas.</Tooltip>}
            >
              <Button
                size="sm"
                onClick={this.handleAddRatings}
                variant="outline-secondary"
              >
                <Star />
              </Button>
            </OverlayTrigger>
          </Row>
          <Row className="mt-3">
            <Add onClick={this.handleAdd} />
          </Row>
        </Col>
      </Row>
    );
  }
}

export default Films;
