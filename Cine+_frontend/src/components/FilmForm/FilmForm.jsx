import React, { Component } from "react";
import {
  Form,
  Button,
  Row,
  Col,
  Container,
  Image,
  ListGroup,
  ListGroupItem,
  Toast,
} from "react-bootstrap";
import "./FilmForm.css";
import { TrashFill } from "react-bootstrap-icons";
import Add from "../Add/Add";

class FilmForm extends Component {
  state = {
    edit: false,
    filmEdit: {},
    genres: [
      { name: "Drama", id: 1 },
      { name: "Comedia", id: 2 },
    ],
    rols: [
      { name: "Actor", id: 1 },
      { name: "Director", id: 2 },
    ],
    showToast: false,
    newGenre: undefined,
    newMemberName: undefined,
    newMemberRol: undefined,
    selectedGenres: [],
    selectedRols: [],
    file: undefined,
    fileTmpURL: undefined,
  };
  onChange = (e) => {
    e.preventDefault();
    if (this.state.selectedPositions.includes(e.target.value)) {
      this.setState((prevState) => ({
        selectedPositions: [
          ...prevState.selectedPositions.filter(
            (item) => item !== e.target.value
          ),
        ],
      }));
    } else {
      let index = e.target.selectedIndex;
      let el = e.target.childNodes[index];
      let option = el.getAttribute("id");
      this.setState((prevState) => ({
        selectedPositions: [...prevState.selectedPositions, option],
      }));
    }
  };

  componentWillMount() {
    console.log(this.props.location.state.film);
    if (this.props.location.state.film) {
      this.setState({
        edit: true,
        filmEdit: this.props.location.state.film,
        // file: this.props.location.state.film.film.img,
        fileTmpURL: this.props.location.state.film.film.imgPath,
        selectedGenres: this.props.location.state.film.film.genres,
        selectedRols: this.props.location.state.film.staff,
      });
    }

    // fetch("https://localhost:44334/api/Genre", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ genres: response});
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
  }

  componentDidMount() {}

  setFile = (e) => {
    let f_url = URL.createObjectURL(e.target.files[0]);
    this.setState({
      fileTmpURL: f_url,
      file: e.target.files[0],
    });
  };

  onFormSubmit = (e) => {
    let formElements = e.target.elements;
    const name = formElements.name.value;
    const year = formElements.year.value;
    const country = formElements.country.value;
    let film = {
      name,
      year,
      country,
    };

    var formdata = new FormData();
    formdata.append("film.name", film.name);
    formdata.append("film.country", film.country);
    formdata.append("film.year", film.year);
    if (this.state.file)
      formdata.append("film.img", this.state.file, this.state.file.name);
    for (let i = 0; i < this.state.selectedGenres.length; i++) {
      formdata.append(`genres[${i}].id`, this.state.selectedGenres[i].id);
      formdata.append(`genres[${i}].name`, this.state.selectedGenres[i].name);
    }
    for (let i = 0; i < this.state.selectedRols.length; i++) {
      formdata.append(`staff[${i}].rol.id`, this.state.selectedRols[i].rol.id);
      formdata.append(
        `staff[${i}].rol.name`,
        this.state.selectedRols[i].rol.name
      );
      formdata.append(`staff[${i}].member`, this.state.selectedRols[i].member);
    }
    let postUrl =
      "https://localhost:44334/api/Film" +
      (this.state.edit ? `/${this.state.filmEdit.id}` : "");
    // fetch(postUrl, {
    //   mode: "cors",
    //   headers: {
    //     Authorization:
    //       "Bearer " + JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
    //   },
    //   method: this.state.edit ? "PATCH" : "POST",
    //   body: formdata,
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
    this.props.history.push({ pathname: "/films", state: { edited: true } });
  };

  addNewGenre = (e) => {
    this.setState({ newGenre: e.target.options.selectedIndex });
  };
  addNewMemberRol = (e) => {
    this.setState({ newMemberRol: e.target.options.selectedIndex });
  };
  addNewMemberName = (e) => {
    this.setState({ newMemberName: e.target.value });
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
  handleAddRol = () => {
    let rol = this.state.newMemberRol;
    let name = this.state.newMemberName;
    if (rol && name) {
      let element = this.state.selectedRols
        .map((rol) => rol.rol)
        .find((c) => c.id === rol);
      if (element) {
        let oldName = this.state.selectedRols.find(
          (c) => c.rol.id === rol
        ).member;
        if (name !== oldName) {
          let newR = this.state.rols.find((c) => c.id === rol);
          let item = { rol: newR, member: name };
          let newRols = [...this.state.selectedRols, item];
          this.setState({ selectedRols: newRols });
        } else {
          this.handleShowToast();
        }
      } else {
        let newR = this.state.rols.find((c) => c.id === rol);
        let item = { rol: newR, member: name };
        let newRols = [...this.state.selectedRols, item];
        this.setState({ selectedRols: newRols });
      }
    }
  };

  handleDeleteGenre = (idG) => {
    let newGenres = this.state.selectedGenres.filter((c) => c.id !== idG);
    this.setState({ selectedGenres: newGenres });
  };

  handleDeleteRol = (rol) => {
    let newRols = this.state.selectedRols.filter(
      (c) => c.rol.id !== rol.rol.id || c.member !== rol.member
    );
    this.setState({ selectedRols: newRols });
  };

  handleShowToast = () => {
    this.setState({ showToast: true });
  };
  handleCloseToast = () => {
    this.setState({ showToast: false });
  };

  render() {
    const { film } = {
      ...this.props.location.state.film,
    };
    return (
      <Container alignSelf="center" className="mt-4">
        <h1 className="mb-5 my-style-header">Película</h1>

        <Col className="center">
          <Form
            onSubmit={this.onFormSubmit}
            style={{ width: "100%", alignItems: "center" }}
          >
            <Row>
              <Col>
                <Form.Group style={{ width: "100%" }} controlId="name">
                  <Form.Label>Nombre:</Form.Label>
                  <Form.Control
                    type="text"
                    defaultValue={film ? film.name : ""}
                  />
                </Form.Group>
              </Col>
              <Col>
                <Form.Group>
                  <Form.Label>Imagen de la película:</Form.Label>
                  <Form.File onChange={this.setFile} id="img" label="" />
                  <Image
                    src={
                      this.state.edit
                        ? `https://localhost:44334/${film.imgPath}`
                        : this.state.fileTmpURL
                    }
                    className="mt-2"
                    style={{ width: "100px" }}
                  />
                </Form.Group>
              </Col>
            </Row>
            <Row>
              <Col>
                <Form.Group controlId="year">
                  <Form.Label>Año:</Form.Label>
                  <Form.Control
                    defaultValue={film ? film.year : ""}
                    type="text"
                    name="year"
                  />
                  <Form.Text id="yearValid" muted>
                    El año debe tener el siguiente formato: YYYY.
                  </Form.Text>
                </Form.Group>
              </Col>
              <Col>
                <Form.Group controlId="age">
                  <Form.Label>País:</Form.Label>
                  <Form.Control
                    defaultValue={film ? film.country : ""}
                    type="text"
                    name="country"
                  />
                </Form.Group>
              </Col>
            </Row>

            <Row>
              <Col>
                <Form.Group controlId="genres">
                  <Form.Label>Géneros:</Form.Label>
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
            <Row style={{ paddingTop: "20px" }}>
              <Col>
                <Form.Group controlId="staff">
                  <Form.Label>Rol:</Form.Label>
                  <Form.Control
                    as="select"
                    onChange={this.addNewMemberRol}
                    custom
                  >
                    <option>{""}</option>
                    {this.state.rols.map((rol) => (
                      <option id={rol.id}>{rol.name}</option>
                    ))}
                  </Form.Control>
                </Form.Group>
              </Col>
              <Col>
                <Form.Group controlId="memberName">
                  <Form.Label>Nombre:</Form.Label>
                  <Form.Control
                    onChange={this.addNewMemberName}
                    type="text"
                    name="memberName"
                  />
                </Form.Group>
              </Col>
              <Col md={1} style={{ marginTop: "30px" }}>
                <Add
                  className="btnFormSend "
                  variant="outline-secondary"
                  onClick={this.handleAddRol}
                />
              </Col>

              <Col>
                <ListGroup style={{ marginTop: "20px" }}>
                  {this.state.selectedRols.map((rol, index) => (
                    <ListGroupItem>
                      {rol.member} ({rol.rol.name})
                      {
                        // isLoggedIn() &&
                        <Button
                          className="ml-3"
                          style={{ padding: "0px", float: "right" }}
                          onClick={() => this.handleDeleteRol(rol)}
                          variant="danger"
                        >
                          <TrashFill style={{ width: "100%" }} />
                        </Button>
                      }
                    </ListGroupItem>
                  ))}
                </ListGroup>
              </Col>
              {/* <Col> */}
              <Toast
                show={this.state.showToast}
                onClose={this.handleCloseToast}
              >
                <Toast.Header>
                  <strong className="mr-auto">¡Atención!</strong>
                </Toast.Header>
                <Toast.Body>
                  Ya existe un miembro de la película con ese nombre y ese rol.
                </Toast.Body>
              </Toast>
              {/* </Col> */}
            </Row>
            <Button
              style={{ float: "right" }}
              className="mt-3 ml-3"
              variant="secondary"
              type="reset"
            >
              Reiniciar
            </Button>
            <Button
              style={{ float: "right" }}
              className="mt-3 ml-3"
              variant="primary"
              type="submit"
              // onClick = {this.onFormSubmit}
            >
              Aceptar
            </Button>
          </Form>
        </Col>
      </Container>
    );
  }
}

export default FilmForm;
