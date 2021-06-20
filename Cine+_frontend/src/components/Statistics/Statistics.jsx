import React, { Component } from "react";
import { Row, Col, Container, Table } from "react-bootstrap";
import { groupBy, onlyUnique, formatDateRequest, compareDates } from "../utils";
import { Typeahead } from "react-bootstrap-typeahead";

class Statistics extends Component {
  state = {
    data: [],
    dataFilter: [],
    options: ["Película", "Género", "Día", "País", "Actor", "Calificación"],
    selectedFilters: "Película",
    grouped: [],
    property: "filmName",
    properties: {
      Día: "reservationDate",
      Película: "filmName",
      País: "country",
      Calificación: "rating",
      Género: "genre",
      Actor: "actor",
    },
  };

  componentWillMount() {
    fetch(`https://localhost:44313/api/Reservation/statistics`, {
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
        let grouped = groupBy(response, ["filmName"]);
        this.setState({
          data: response,
          dataFilter: response,
          grouped: grouped,
        });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  handleFilters = (e) => {
    let filter = e.length !== 0 ? e[0] : "Película";
    if (
      filter === "Película" ||
      filter === "Día" ||
      filter === "País" ||
      filter === "Calificación"
    ) {
      let grouped = groupBy(this.state.data, [this.state.properties[filter]]);
      this.setState({
        grouped: grouped,
        selectedFilters: filter,
        property: this.state.properties[filter],
      });
    } else if (filter === "Género") {
      let g = [];
      this.state.data.forEach((element) => {
        g = g.concat(element.genres.map((c) => c.name));
      });

      let genres = g.filter(onlyUnique);
      let grouped = [];
      genres.forEach((element) => {
        let _items = this.state.data.filter((c) =>
          c.genres.map((c) => c.name).includes(element)
        );
        grouped.push({ genre: element, _items: _items });
      });
      this.setState({
        grouped: grouped,
        selectedFilters: filter,
        property: this.state.properties[filter],
      });
    } else if (filter === "Actor") {
      let a = [];
      this.state.data.forEach((element) => {
        a = a.concat(element.actors);
      });

      let actors = a.filter(onlyUnique);
      let grouped = [];
      actors.forEach((element) => {
        let _items = this.state.data.filter((c) => c.actors.includes(element));
        grouped.push({ actor: element, _items: _items });
      });
      this.setState({
        grouped: grouped,
        selectedFilters: filter,
        property: this.state.properties[filter],
      });
    }
  };

  render() {
    return (
      <Container className="mt-5">
        <Row className="mb-3">
          <h4>Estadísticas de las ventas de Cine+</h4>
        </Row>
        <Row>
          <Col>
            <Table bordered striped hover>
              <thead>
                <th>{this.state.selectedFilters}</th>
                <th>Ventas</th>
              </thead>
              <tbody>
                {this.state.grouped.map((c) => (
                  <tr>
                    <td>
                      {this.state.property === "reservationDate"
                        ? formatDateRequest(c[this.state.property])
                        : c[this.state.property]}
                    </td>
                    <td>{c._items.length}</td>
                  </tr>
                ))}
              </tbody>
            </Table>
          </Col>
          <Col md={4}>
            <Row>
              <Col className="ml-5 mb-3">
                <h5>Escoja un filtro para la búsqueda</h5>
              </Col>
            </Row>
            <Row>
              <Col>
                <Typeahead
                  onChange={this.handleFilters}
                  className="mb-5"
                  style={{ width: "90%", float: "right" }}
                  clearButton
                  id="selections-example"
                  options={this.state.options}
                  placeholder="Elija una película..."
                />
              </Col>
            </Row>
          </Col>
        </Row>
      </Container>
    );
  }
}

export default Statistics;
