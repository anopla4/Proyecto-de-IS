import React, { Component } from "react";
import {
  Container,
  Card,
  Row,
  Col,
  Accordion,
  CardDeck,
} from "react-bootstrap";
import "../../containers/App/App.css";
import "./Films.css";
import Add from "../Add/Add";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import ReactStars from "react-rating-stars-component";

class Films extends Component {
  state = {
    filmsRated: [],
    films: [],
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
        this.setState({ films: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }
  handleAdd = () => {
    this.props.history.push({ pathname: "/filmForm", state: {} });
  };

  addRated = (newRate, idF) => {
    let film = this.state.filmsRated.find((c) => c.id === idF);
    let temp = [...this.state.filmsRated];
    if (film) {
      let index = temp.indexOf(film);
      temp[index].rate = newRate;
    } else {
      temp = [...temp, { id: idF, rate: newRate }];
    }
    this.setState({ filmsRated: temp });
  };

  componentWillUnmount() {}

  handleOnDelete = (id, index) => {
    // fetch(`https://localhost:44334/api/Film/${id}`, {
    //   mode: "cors",
    //   method: "DELETE",
    //   headers: {
    //     Authorization:
    //       "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
    //   },
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
    // let n_films = [...this.state.films];
    // n_films.splice(index, 1);
    // this.setState({ films: n_films });
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
                  <Card.Body>
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
                      {film.staff.map((member) => (
                        <Container>
                          <p style={{ display: "inline" }} className="bold">
                            {member.rol.name}:{" "}
                          </p>
                          {member.member}.
                        </Container>
                      ))}
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
          <Add onClick={this.handleAdd} />
        </Col>
      </Row>
    );
  }
}

export default Films;
