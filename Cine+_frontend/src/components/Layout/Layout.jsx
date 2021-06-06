import React from "react";
import { Container, Row } from "react-bootstrap";
import Navigation from "../NavBar/NavBar";

const layout = (props) => {
  return (
    <Container>
      <Row>
        <Navigation />
      </Row>
      <main className="mt-5">{props.children}</main>
    </Container>
  );
};
export default layout;
