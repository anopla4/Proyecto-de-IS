import React, { Component } from "react";
import { Container, Card, Row, Col, CardDeck } from "react-bootstrap";
import "../../containers/App/App.css";
import Add from "../Add/Add";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import { groupBy } from "../utils";

class Films extends Component {
  state = {
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
  };

  componentDidMount() {
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
    //     this.setState({ films: response });
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
  }
  handleAdd = () => {
    this.props.history.push({ pathname: "/filmForm", state: {} });
  };
  handleOnDelete = (id) => {};
  handleOnEdit = (film) => {
    this.props.history.push({ pathname: "/filmForm", state: { film: film } });
  };

  render() {
    return (
      <Row>
        <Col>
          <CardDeck>
            {this.state.films.map((film) => (
              <Col md={3}>
                <Card className="mb-3">
                  <Card.Img
                    variant="top"
                    src={`http://localhost:8000/${film.film.imgPath}`}
                  />
                  <Card.Body>
                    <Card.Text>
                      <Container>
                        <p style={{ display: "inline" }} className="bold">
                          Géneros:{" "}
                        </p>
                        {film.film.genres.map((genre) => genre.name).join(", ")}
                        .
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
                        onDelete={() => this.handleOnDelete(film.film.id)}
                        onEdit={() => this.handleOnEdit(film)}
                        delete={true}
                        edit={true}
                      />
                    </Card.Text>
                  </Card.Body>
                </Card>
              </Col>
            ))}
            ;
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
