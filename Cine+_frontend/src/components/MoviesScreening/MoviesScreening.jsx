import React, { Component } from "react";
import {
  Card,
  CardDeck,
  Row,
  Col,
  ListGroup,
  Container,
  Button,
} from "react-bootstrap";
import "./MoviesScreening.css";

class MoviesScreening extends Component {
  state = {
    movies: [
      {
        id: 1,
        name: "Cinema Paradiso",
        year: "1988",
        genre: { name: "Drama" },
        country: "Italia",
        imgPath: "src/images/cinemaParadiso.jpg",
        dates: [{ date: "5/6/2021", times: ["8:00", "10:00"] }],
      },
    ],
  };

  //   componentDidMount() {
  //     fetch("https://localhost:44334/api/FilmScreening/WithTimes", {
  //       mode: "cors",
  //     })
  //       .then((response) => {
  //         if (!response.ok) {
  //           throw Error(response.statusText);
  //         }
  //         return response.json();
  //       })
  //       .then((response) => {
  //         this.setState({ movies: response });
  //       })
  //       .catch(function (error) {
  //         console.log("Hubo un problema con la petición Fetch:" + error.message);
  //       });
  //   }

  render() {
    return (
      <CardDeck>
        {this.state.movies.map((movie) => (
          <Col md={3}>
            <Card>
              <Card.Img
                fluid
                variant="top"
                src={`http://localhost:8000/${movie.imgPath}`}
              />
              <Card.Body>
                <Card.Title>
                  {movie.name} ({movie.year})
                </Card.Title>
                <Card.Subtitle>Género: {movie.genre.name}</Card.Subtitle>
              </Card.Body>
              {movie.dates.map((date) => (
                <ListGroup key={movie.id} className="list-group-flush">
                  <Row>
                    <Col style={{ margin: "10px" }}>
                      <h6 className="center-date">{date.date}</h6>
                    </Col>
                    <Col>
                      <Container
                        style={{ width: "100%", marginTop: "10px" }}
                        className="center-date"
                      >
                        {date.times.map((time) => (
                          <Button
                            variant="default"
                            bsPrefix="my-button"
                            className="my-button mb-2 ml-2"
                          >
                            {time}
                          </Button>
                        ))}
                      </Container>
                    </Col>
                  </Row>
                </ListGroup>
              ))}
            </Card>
          </Col>
        ))}
      </CardDeck>
    );
  }
}

export default MoviesScreening;
