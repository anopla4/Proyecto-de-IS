import React, { Component } from "react";
import { Button } from "react-bootstrap";
import { PlusLg } from "react-bootstrap-icons";
import { isLoggedIn } from "../utils";

class Add extends Component {
  state = {};
  render() {
    return (
      // isLoggedIn() &&
      <Button
        className="mr-3"
        style={{ float: "right" }}
        onClick={this.props.onClick}
        variant="primary"
      >
        <PlusLg />
        {this.props.text}
      </Button>
    );
  }
}

export default Add;
