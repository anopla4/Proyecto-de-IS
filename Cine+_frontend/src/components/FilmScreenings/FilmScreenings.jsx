import React, { Component } from "react";
import { Container, Nav, Row, Card, Tabs, Tab, Button } from "react-bootstrap";
import MovieScreenings from "../MoviesScreening/MoviesScreening";
import "./FilmScreenings.css";

class FilmScreenings extends Component {
  state = { page: 1 };

  handleOnClick = (p) => {
    this.setState({ page: p });
  };

  render() {
    return (
      <Container>
        <Row style={{ paddingTop: "30px" }} className="justify-content-end">
          <Button
            variant="outline-secondary"
            // bsPrefix="my-button"
            className="mb-2 ml-2"
            onClick={() => this.handleOnClick(1)}
          >
            Por películas
          </Button>
          <Button
            variant="outline-secondary"
            // bsPrefix="my-button"
            className="mb-2 ml-2"
            onClick={() => this.handleOnClick(2)}
          >
            Por fecha/horarios
          </Button>
          <Button
            variant="outline-secondary"
            // bsPrefix="my-button"
            className="mb-2 ml-2"
            onClick={() => this.handleOnClick(3)}
          >
            Por salas
          </Button>
        </Row>
        <Row className="mt-5">
          {this.state.page === 1 && <MovieScreenings />}
        </Row>
      </Container>

      // <Tab.Container>
      //   <Row className="justify-content-end">
      // <Tabs className="myClass" defaultActiveKey={1}>
      //   <Tab eventKey={1} title="Por películas">
      //     <MovieScreenings />
      //   </Tab>
      //   <Tab eventKey={2} title="Por fechas/horarios"></Tab>
      //   <Tab eventKey={3} title="Por salas"></Tab>
      // </Tabs>
      // </Row>
      // <Row>
      //   <Tab.Content className="mt-5" style={{ width: "100%" }}>
      //     <Tab.Pane eventKey={1} title="Por películas"></Tab.Pane>
      //     <Tab.Pane eventKey={2} title="Por fechas/horarios"></Tab.Pane>
      //     <Tab.Pane eventKey={3} title="Por salas"></Tab.Pane>
      //   </Tab.Content>
      // </Row>
      // </Tab.Container>
      // <Tabs defaultActiveKey="profile" id="uncontrolled-tab-example">
      //   <Tab eventKey="home" title="Home"></Tab>
      //   <Tab eventKey="profile" title="Profile"></Tab>
      //   <Tab eventKey="contact" title="Contact" disabled></Tab>
      // </Tabs>
    );
  }
}

export default FilmScreenings;
