import React, { Component } from "react";
import { Carousel } from "react-bootstrap";
import "./Home.css";

class Home extends Component {
  state = {
    top10: [
      {
        id: 1,
        name: "Pulp Fiction",
        year: "1994",
        country: "Estados Unidos",
        imgPath: "src/images/pulpFiction.jpg",
      },
      {
        id: 2,
        name: "Cinema Paradiso",
        year: "1988",
        country: "Italia",
        imgPath: "src/images/cinemaParadiso.jpg",
      },
    ],
  };
  render() {
    return (
      <Carousel className="mt-5" bsprefix=" carousel" fade>
        {this.state.top10.map((film) => (
          <Carousel.Item bsPrefix="carousel-item">
            <img
              width="30%"
              src={`http://localhost:8000/${film.imgPath}`}
              alt=""
            />
            <Carousel.Caption>
              <h3>
                {film.name} ({film.year})
              </h3>
              <p>{film.country}</p>
            </Carousel.Caption>
          </Carousel.Item>
        ))}
      </Carousel>
    );
  }
}

export default Home;
