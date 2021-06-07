import React, { Component } from "react";
import { Container, Card, Row, Col, CardDeck } from "react-bootstrap";
import "../../containers/App/App.css";
import Add from "../Add/Add";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import { groupBy } from "../utils";

class Films extends Component {
  state = {
    grouped: [],
    films: [
      {
        film: {
          id: 1,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        member: { name: "John Travolta" },
        rol: { name: "Actor" },
      },
      {
        film: {
          id: 1,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        member: { name: "Quentin Tarantino" },
        rol: { name: "Director" },
      },
      {
        film: {
          id: 2,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        member: { name: "John Travolta" },
        rol: { name: "Actor" },
      },
      {
        film: {
          id: 3,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        member: { name: "John Travolta" },
        rol: { name: "Actor" },
      },
      {
        film: {
          id: 4,
          name: "Pulp Fiction",
          year: "1988",
          genre: { name: "Drama" },
          country: "Italia",
          imgPath: "src/images/pulpFiction.jpg",
        },
        member: { name: "John Travolta" },
        rol: { name: "Actor" },
      },
    ],
  };

  componentDidMount() {
    let grouped = groupBy(this.state.films, ["film.id"]);
    console.log(grouped);
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
    //     this.setState({ films: response });
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
  }
  handleAdd = () => {
    this.state.push("/filmForm");
  };
  handleOnDelete = (id) => {};
  handleOnEdit = (film) => {
    this.state.push({ pathname: "/filmForm", state: film });
  };

  render() {
    return (
      <Row>
        <Col>
          <CardDeck>
            {this.state.grouped.map((film) => (
              <Col md={3}>
                <Card className="mb-3">
                  <Card.Img
                    variant="top"
                    src={`http://localhost:8000/${film.film.imgPath}`}
                  />
                  <Card.Body>
                    <Card.Text>
                      {film._items.map((member) => (
                        <Container>
                          <p style={{ display: "inline" }} className="bold">
                            {member.rol.name}:{" "}
                          </p>
                          {member.member.name}.
                        </Container>
                      ))}
                      <DeleteEdit
                        onDelete={() => this.handleOnDelete(film.film.id)}
                        onEdit={() => this.handleOnEdit(film._items)}
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
