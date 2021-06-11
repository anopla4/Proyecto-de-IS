import React, { Component } from "react";
import { Carousel, Container } from "react-bootstrap";
import "./Home.css";
import DeleteEdit from "../DeleteEdit/DeleteEdit";

class Home extends Component {
  state = {
    top10: [
      {
        id: "1",
        name: "Pulp Fiction",
        year: "1994",
        country: "Estados Unidos",
        imgPath: "src/images/pulpFiction.jpg",
      },
      {
        id: "2",
        name: "Cinema Paradiso",
        year: "1988",
        country: "Italia",
        imgPath: "src/images/cinemaParadiso.jpg",
      },
    ],
  };

  componentWillMount() {
    // fetch("https://localhost:44334/api/Top10", {
    //   mode: "cors",
    // })
    //   .then((response) => {
    //     if (!response.ok) {
    //       throw Error(response.statusText);
    //     }
    //     return response.json();
    //   })
    //   .then((response) => {
    //     this.setState({ top10: response });
    //   })
    //   .catch(function (error) {
    //     console.log("Hubo un problema con la petición Fetch:" + error.message);
    //   });
  }

  onEditTop10 = () => {
    let top10 = this.state.top10;
    this.props.history.push({ pathname: "/top10Form", state: { top10 } });
  };

  render() {
    return (
      <Container className="mt-5">
        <DeleteEdit edit={true} onEdit={this.onEditTop10} />
        <Carousel bsprefix="carousel" fade>
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
      </Container>
    );
  }
}

export default Home;
