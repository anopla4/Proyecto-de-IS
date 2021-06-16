import React, { Component, ReactPropTypes } from "react";
import {
  Container,
  Card,
  Row,
  Col,
  Image,
  Button,
  CardDeck,
} from "react-bootstrap";
import logoBlack from "../../static/logoBlack.png";
import { Printer } from "react-bootstrap-icons";
import { withRouter } from "react-router-dom";
import { jsPDF } from "jspdf";
import html2canvas from "html2canvas";
import { formatDateRequest } from "../utils";

class PurchaseOrder extends Component {
  state = { takenSeats: [], filmScreening: undefined, points: [], prices: [] };

  componentWillMount() {
    let takenSeats = this.props.location.state.takenSeats;
    let points = this.props.location.state.points;
    let prices = this.props.location.state.prices;

    let filmScreening = this.props.location.state.filmScreening;
    this.setState({
      filmScreening: filmScreening,
      takenSeats: takenSeats,
      points: points,
      prices: prices,
    });
  }

  print = () => {
    const input = document.getElementById("tickets");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new jsPDF();
      pdf.addImage(imgData, "JPEG", 0, 0);
      pdf.save("entradas.pdf");
    });
  };

  pay = () => {
    this.props.history.push({
      pathname: "/payment",
      state: {
        points: this.state.points,
        modifiedPrice: this.props.location.state.modifiedPrice,
        purchaseOrderId: this.props.location.state.purchaseOrderId,
      },
    });
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
            {this.state.takenSeats.map((seat, index) => (
              <Card
                id={seat.seat.id}
                className="mt-3"
                bg="light"
                style={{ width: "70%" }}
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
                            Película:{" "}
                            {this.state.filmScreening
                              ? this.state.filmScreening.film.name
                              : ""}
                          </Row>
                          <Row className="mb-2">
                            Fecha:{" "}
                            {this.state.filmScreening
                              ? formatDateRequest(this.state.filmScreening.date)
                              : ""}
                          </Row>
                          <Row className="mb-2">
                            Hora:{" "}
                            {this.state.filmScreening
                              ? this.state.filmScreening.startTime
                              : ""}
                          </Row>
                          <Row className="mb-2">
                            Precio: {this.state.prices[index]}
                          </Row>
                          <Row className="mb-2">
                            Puntos: {this.state.points[index]}
                          </Row>
                        </Col>
                        <Col>
                          <Row className="mb-2">Sala: {seat.room.name}</Row>
                          <Row className="mb-2">Nivel: {seat.level.name}</Row>
                          <Row className="mb-2">
                            Sección: {seat.section.name}
                          </Row>
                          <Row className="mb-2">Asiento: {seat.seat.code}</Row>
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

        <Button onClick={this.pay} style={{ float: "right" }}>
          Pagar
        </Button>
      </Container>
    );
  }
}

export default withRouter(PurchaseOrder);
