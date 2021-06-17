import React, { Component } from "react";
import { Container, Row, Col } from "react-bootstrap";
import MovieScreenings from "../MoviesScreening/MoviesScreening";
import "./FilmScreenings.css";
import "../../containers/App/App.css";
import Add from "../Add/Add";

class FilmScreenings extends Component {
  state = { movieScreenings: [] };

  handleOnAdd = () => {
    this.props.history.push({
      pathname: "/filmScreeningForm",
      state: {},
    });
  };

  render() {
    return (
      <Container className="mt-5">
        <Row style={{ paddingTop: "30px" }} className="justify-content-end">
          <Col>
            <MovieScreenings />
          </Col>
          <Col style={{ padding: "0px" }} md={1}>
            {(JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "WebMaster"
            ) ||
              JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
                "Admin"
              )) && <Add className="mr-0" onClick={this.handleOnAdd} />}
          </Col>
        </Row>
      </Container>
    );
  }
}

export default FilmScreenings;
