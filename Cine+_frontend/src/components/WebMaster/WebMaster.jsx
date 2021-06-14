import React, { Component } from "react";
import { Container, Form, InputGroup, Table } from "react-bootstrap";
import "./WebMaster.css";

class WebMaster extends Component {
  state = { users: [{ username: "anopla", email: "anopl4@gmail.com" }] };
  render() {
    return (
      <Container className="mt-5">
        <Table style={{ textAlign: "center" }} bordered striped hover>
          <thead>
            <th>Nombre de usuario</th>
            <th>Correo</th>
            <th>Administrador</th>
            <th>Contable</th>
            <th>Trabajador</th>
          </thead>
          <tbody>
            {this.state.users.map((user) => (
              <tr id={user.username}>
                <td>{user.username}</td>
                <td>{user.email}</td>
                <td>
                  <Form.Check defaultChecked={user.} />
                </td>
                <td>
                  <Form.Check />
                </td>
                <td>
                  <Form.Check />
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
      </Container>
    );
  }
}

export default WebMaster;
