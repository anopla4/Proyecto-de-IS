import React, { Component } from "react";
import { Carousel, Row, Col, Card } from "react-bootstrap";
import "./Home.css";
import cinema from "../../static/cinema.jpg";
import DeleteEdit from "../DeleteEdit/DeleteEdit";
import { isLoggedIn } from "../utils";

class Home extends Component {
  state = {
    top10: [],
  };

  componentWillMount() {
    fetch("https://localhost:44313/api/Top10", {
      mode: "cors",
    })
      .then((response) => {
        if (!response.ok) {
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((response) => {
        this.setState({ top10: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  }

  onEditTop10 = () => {
    let top10 = this.state.top10;
    this.props.history.push({ pathname: "/top10Form", state: { top10 } });
  };

  render() {
    console.log(JSON.parse(localStorage.getItem("loggedUser")).roles);
    return (
      <Row className="mt-5">
        <Col>
          {isLoggedIn() &&
            (JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
              "WebMaster"
            ) ||
              JSON.parse(localStorage.getItem("loggedUser")).roles.includes(
                "Admin"
              )) && <DeleteEdit edit={true} onEdit={this.onEditTop10} />}
          <Carousel style={{ width: "80%" }} bsprefix="carousel" fade>
            {this.state.top10.map((film) => (
              <Carousel.Item bsPrefix="carousel-item">
                <img
                  width="50%"
                  src={`https://localhost:44313/${film.film.imgPath}`}
                  alt=""
                />
                <Carousel.Caption
                  style={{ textAlign: "right", fontSize: "15px" }}
                >
                  <h5>
                    {film.film.name} ({film.film.year})
                  </h5>
                  <p>{film.film.country}</p>
                </Carousel.Caption>
              </Carousel.Item>
            ))}
          </Carousel>
        </Col>
        <Col md={3}>
          <Card style={{ width: "18rem" }}>
            <Card.Img variant="top" src={cinema} />
            <Card.Body>
              <Card.Title>Unirse a la comunidad de Cine+</Card.Title>
              <Card.Text>
                No lo piense más y hágase miembro de nuestro cine. Forme parte
                de nuestro sistema de puntos que le permitirán entrar en
                nuestras puestas en escena con la cantidad acumulada al comprar
                entradas. Háganos saber sus preferencias cinematográficas para
                recomendarle películas.
              </Card.Text>
              <Card.Link style={{ float: "right" }} href="/clubMemberForm">
                Unirme
              </Card.Link>
            </Card.Body>
          </Card>
          <Card className="mt-3" style={{ width: "18rem" }}>
            <Card.Header>
              Sobre las películas... (las que se prefieren poner en Cine+)
            </Card.Header>
            <Card.Body>
              <blockquote className="blockquote mb-0">
                <p>
                  {" "}
                  Un buen vino es como una buena película: dura un instante y te
                  deja en la boca un sabor a gloria; es nuevo en cada sorbo y,
                  como ocurre con las películas, nace y renace en cada
                  saboreador.{" "}
                </p>
                <footer className="blockquote-footer">Stanley Kubrick</footer>
              </blockquote>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    );
  }
}

export default Home;
