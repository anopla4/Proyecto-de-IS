import React, { Component } from "react";
import {
  Table,
  Row,
  Col,
  ListGroupItem,
  ListGroup,
  Toast,
  Button,
  Container,
} from "react-bootstrap";
import Add from "../Add/Add";
import DeleteEdit from "../DeleteEdit/DeleteEdit";

class Top10Form extends Component {
  state = {
    films: [],
    top10: [],
    showToast: false,
    error: "",
  };

  componentWillMount() {
    this.setState({ top10: this.props.location.state.top10 });
  }

  componentDidMount() {
    fetch("https://localhost:44313/api/UserFilm/allFilmsRatings", {
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

  onDeleteFilm = (index) => {
    let n_top10 = [...this.state.top10];
    n_top10.splice(index, 1);
    this.setState({ top10: n_top10 });
  };

  addMovieToTop10 = (film) => {
    if (!this.state.top10.map((film) => film.id).includes(film.id)) {
      if (this.state.top10.length === 10) {
        this.handleShowToast();
      } else {
        let newTop10 = [...this.state.top10, film];
        this.setState({ top10: newTop10 });
      }
    }
  };

  handleShowToast = () => {
    this.setState({ showToast: true });
  };
  handleCloseToast = () => {
    this.setState({ showToast: false });
  };

  onFormSubmit = () => {
    var formdata = new FormData();
    for (let i = 0; i < this.state.top10.length; i++) {
      formdata.append(`filmsIds[${i}]`, this.state.top10[i].id);
    }
    fetch("https://localhost:44313/api/Top10", {
      mode: "cors",
      headers: {
        Authorization:
          "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
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
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  };

  render() {
    return (
      <Container className="mt-5">
        <Row>
          <Col>
            <h4>Películas disponibles</h4>
            <Table className="mt-4" striped hover bordered>
              <thead>
                <th>Película</th>
                <th>Número de vistas</th>
                <th>Valoración</th>
              </thead>
              <tbody>
                {this.state.films.map((film) => (
                  <tr>
                    <td>{film.name}</td>
                    <td>{film.timesSeen}</td>
                    <td>{film.rating}</td>
                    <td>
                      <Add
                        variant={"secondary"}
                        onClick={() => this.addMovieToTop10(film)}
                      />
                    </td>
                  </tr>
                ))}
              </tbody>
            </Table>
          </Col>
          <Col>
            <h4>Top10</h4>
            <Toast show={this.state.showToast} onClose={this.handleCloseToast}>
              <Toast.Header>
                <strong className="mr-auto">¡Atención!</strong>
              </Toast.Header>
              <Toast.Body>Ya han sido añadidas diez películas.</Toast.Body>
            </Toast>
            <ListGroup className="mt-4">
              {this.state.top10.map((film, index) => (
                <ListGroupItem>
                  <Row>
                    <Col>
                      {film.name} ({film.year}) - {film.country}
                    </Col>
                    <Col md={2}>
                      {" "}
                      <DeleteEdit
                        delete={true}
                        onDelete={() => this.onDeleteFilm(index)}
                      />
                    </Col>
                  </Row>
                </ListGroupItem>
              ))}
            </ListGroup>
          </Col>
        </Row>
        <Row className="mt-3">
          <Col>
            <Button onClick={this.onFormSubmit} style={{ float: "right" }}>
              Aceptar
            </Button>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default Top10Form;
