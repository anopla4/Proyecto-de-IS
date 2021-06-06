import React, { Component } from "react";
import { Container, Nav, Row, Card, Tabs, Tab } from "react-bootstrap";
import MovieScreenings from "../MoviesScreening/MoviesScreening";
import "./FilmScreenings.css";

class FilmScreenings extends Component {
  state = { page: 1 };

  handleOnClick = (p) => {
    this.setState({ page: p });
  };

  render() {
    return (
      <Tab.Container defaultActiveKey={1}>
        <Row className="justify-content-end">
          <Nav variant="tabs">
            <Nav.Item>
              <Nav.Link eventKey={1}>Por películas</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link eventKey={2}>Por fechas/horarios</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link eventKey={3}>Por salas</Nav.Link>
            </Nav.Item>
          </Nav>
        </Row>
        <Row>
          <Tab.Content className="mt-5" style={{ width: "100%" }}>
            <Tab.Pane eventKey={1} title="Por películas">
              <MovieScreenings />
            </Tab.Pane>
            <Tab.Pane eventKey={2} title="Por fechas/horarios"></Tab.Pane>
            <Tab.Pane eventKey={3} title="Por salas"></Tab.Pane>
          </Tab.Content>
        </Row>
      </Tab.Container>
    );
  }
}

export default FilmScreenings;
