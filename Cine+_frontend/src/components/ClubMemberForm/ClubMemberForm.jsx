import React, { Component } from "react";
import {
  Container,
  Row,
  Col,
  Form,
  ListGroup,
  ListGroupItem,
  Image,
  Button,
  Modal,
} from "react-bootstrap";
import { TrashFill } from "react-bootstrap-icons";
import Add from "../Add/Add";
import { formatDateRequest } from "../utils";

class ClubMemberForm extends Component {
  state = {
    genres: [],
    selectedGenres: [],
    validated: false,
    error: "",
  };

  componentWillMount() {
    fetch("https://localhost:44313/api/Genre", {
      mode: "cors",
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
      .then((response) => {
        this.setState({ genres: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  setFile = (e) => {
    let f_url = URL.createObjectURL(e.target.files[0]);
    this.setState({
      fileTmpURL: f_url,
      file: e.target.files[0],
    });
  };

  onFormSubmit = (e) => {
    e.preventDefault();
    const form = e.currentTarget;
    if (form.checkValidity() === false) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({ validated: true });
    } else {
      let formElements = e.target.elements;
      const name = formElements.name.value;
      const birthdate = formElements.birthdate.value;
      const nationality = formElements.nationality.value;
      let member = {
        name,
        birthdate,
        nationality,
      };

      var formdata = new FormData();
      formdata.append("clubMember.name", member.name);
      formdata.append("clubMember.dateOfBirth", member.birthdate);
      formdata.append("clubMember.nationality", member.nationality);
      formdata.append(
        "clubMember.userId",
        JSON.parse(localStorage.getItem("loggedUser")).userId
      );

      if (this.state.file)
        formdata.append("film.img", this.state.file, this.state.file.name);
      for (let i = 0; i < this.state.selectedGenres.length; i++) {
        formdata.append(`genres[${i}].id`, this.state.selectedGenres[i].id);
        formdata.append(`genres[${i}].name`, this.state.selectedGenres[i].name);
      }
      let postUrl = `https://localhost:44313/api/ClubMember/${
        JSON.parse(localStorage.getItem("loggedUser")).userId
      }`;
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
            this.setState({ error: `${response.status}` });
          } else {
            this.props.history.push("/");
          }
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
    }
  };

  addNewGenre = (e) => {
    this.setState({ newGenre: e.target.children[e.target.selectedIndex].id });
  };

  handleAddGenre = () => {
    let g = this.state.newGenre;
    if (g) {
      let element = this.state.selectedGenres.find((c) => c.id === g);
      if (!element) {
        let newG = this.state.genres.find((c) => c.id === g);
        let newGenres = [...this.state.selectedGenres, newG];
        this.setState({ selectedGenres: newGenres });
      }
    }
  };

  handleDeleteGenre = (idG) => {
    let newGenres = this.state.selectedGenres.filter((c) => c.id !== idG);
    this.setState({ selectedGenres: newGenres });
  };

  render() {
    return (
      <Container className="mt-5">
        <h3>Formulario para convertirse en miembro del club de Cine+</h3>
        {this.state.error !== "" && (
          <Modal.Dialog>
            <Modal.Header>
              <Modal.Title>Atención</Modal.Title>
            </Modal.Header>

            <Modal.Body>
              <p>{this.state.error}</p>
            </Modal.Body>

            <Modal.Footer>
              <Button
                onClick={() => this.setState({ error: "" })}
                variant="secondary"
              >
                Close
              </Button>
            </Modal.Footer>
          </Modal.Dialog>
        )}
        <Form
          noValidate
          validated={this.state.validated}
          onSubmit={this.onFormSubmit}
        >
          <Row className="mt-5">
            <Col>
              <Form.Group style={{ width: "100%" }} controlId="name">
                <Form.Label>Nombre:</Form.Label>
                <Form.Control required type="text" />
              </Form.Group>
            </Col>
            <Col>
              <Form.Group>
                <Form.Label>Foto:</Form.Label>
                <Row>
                  <Col>
                    <Form.File
                      onChange={this.setFile}
                      id="img"
                      label=""
                      custom
                    />
                  </Col>
                  <Col>
                    <Image
                      src={this.state.fileTmpURL}
                      className="mt-2"
                      style={{ width: "100px" }}
                    />
                  </Col>
                </Row>
              </Form.Group>
            </Col>
          </Row>
          <Row>
            <Col>
              <Form.Group controlId="birthdate">
                <Form.Label>Fecha de nacimiento:</Form.Label>
                <Form.Control type="date" name="birthdate" />
              </Form.Group>
            </Col>
            <Col>
              <Form.Group controlId="nationality">
                <Form.Label>Nacionalidad:</Form.Label>
                <Form.Control type="text" name="nationality" />
              </Form.Group>
            </Col>
          </Row>
          <Row>
            <Col>
              <Form.Group controlId="genres">
                <Form.Label>Géneros favoritos:</Form.Label>
                <Form.Control as="select" onChange={this.addNewGenre} custom>
                  <option>{""}</option>
                  {this.state.genres.map((genre) => (
                    <option id={genre.id}>{genre.name}</option>
                  ))}
                </Form.Control>
              </Form.Group>
            </Col>
            <Col md={1} style={{ marginTop: "30px" }}>
              <Add
                className="btnFormSend "
                variant="outline-secondary"
                onClick={this.handleAddGenre}
              />
            </Col>
            <Col>
              <ListGroup style={{ marginTop: "20px" }}>
                {this.state.selectedGenres.map((genre, index) => (
                  <ListGroupItem>
                    {genre.name}
                    {
                      // isLoggedIn() &&
                      <Button
                        className="ml-3"
                        style={{ padding: "0px", float: "right" }}
                        onClick={() => this.handleDeleteGenre(genre.id)}
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
          <Button style={{ float: "right" }} type="submit">
            Aceptar
          </Button>
        </Form>
      </Container>
    );
  }
}

export default ClubMemberForm;
