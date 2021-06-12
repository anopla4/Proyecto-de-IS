import React, { Component } from "react";
import {
  Container,
  Card,
  Row,
  Col,
  Image,
  Button,
  CardDeck,
} from "react-bootstrap";
import ReactToPrint, { PrintContextConsumer } from "react-to-print";
import logoBlack from "../../static/logoBlack.png";
import { Printer } from "react-bootstrap-icons";

class PurchaseOrder extends Component {
  state = { takenSeats: [], filmScreening: undefined };

  componentWillMount() {
    let takenSeats = this.props.location.state.takenSeats;
    let filmScreening = this.props.location.state.filmScreening;
    this.setState({ filmScreening: filmScreening, takenSeats: takenSeats });
  }

  print = () => {
    var content = document.getElementById("tickets");
    // var pri = document.getElementById("iftickets").contentWindow;
    console.log(content);
    // console.log(pri);
    // pri.document.open();
    // pri.document.write(content.innerHTML);
    // pri.document.close();
    // pri.focus();
    // pri.print();
  };

  render() {
    return (
      <Container className="mt-5">
        <h3>Entradas</h3>

        <Button
          onClick={this.print}
          style={{ float: "right" }}
          variant="outline-secondary"
        >
          <Printer />
        </Button>
        <CardDeck ref={(el) => (this.componentRef = el)} id="tickets">
          <Col>
            {this.state.takenSeats.map((seat) => (
              <Card
                id={seat.seat.id}
                className="mt-3"
                bg="light"
                style={{ width: "80%" }}
              >
                <Row className="mt-3">
                  <Col>
                    <Card.Title className="ml-4 mb-3">
                      <h4>Cine+</h4>
                    </Card.Title>
                    <Card.Subtitle>
                      <Row className="ml-4">
                        <Col>
                          <Row className="mb-2">
                            Película: {this.state.filmScreening.film.name}
                          </Row>
                          <Row className="mb-2">
                            Fecha: {this.state.filmScreening.date}
                          </Row>
                          <Row className="mb-2">
                            Hora: {this.state.filmScreening.time}
                          </Row>
                        </Col>
                        <Col>
                          <Row className="mb-2">Sala: {seat.room.name}</Row>
                          <Row className="mb-2">Nivel: {seat.level.name}</Row>
                          <Row className="mb-2">
                            Sección: {seat.section.name}
                          </Row>
                          <Row className="mb-2">Asiento: {seat.seat.id}</Row>
                        </Col>
                      </Row>
                    </Card.Subtitle>
                  </Col>
                  <Col md={4}>
                    <Image width="60%" fluid src={logoBlack} alt="" />
                  </Col>
                </Row>
              </Card>
            ))}
          </Col>
        </CardDeck>

        <Button style={{ float: "right" }}>Pagar</Button>
      </Container>
    );
  }
}

export default PurchaseOrder;
