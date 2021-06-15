import React, { Component } from "react";
import { Container, Form, Button, Table } from "react-bootstrap";
import { compareList } from "../utils";
import "./WebMaster.css";

class WebMaster extends Component {
  state = {
    users: [],
    modifiedUsers: [],
  };

  componentDidMount = () => {
    fetch("https://localhost:44313/api/User", {
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
        this.setState({ users: response });
      })
      .catch(function (error) {
        console.log("Hubo un problema con la petición Fetch:" + error.message);
      });
  };

  handleModifyUser = (e, rol, email, index) => {
    let user = { ...this.state.users[index] };
    let modifiedUser = this.state.modifiedUsers.find((c) => c.email === email);
    let modifiedUserIndex = this.state.modifiedUsers.indexOf(modifiedUser);

    let newRols = modifiedUser ? [...modifiedUser.roles] : [...user.roles];
    if (e.target.checked) newRols.push(rol);
    else newRols = newRols.filter((c) => c !== rol);

    if (compareList(user.roles, newRols)) {
      let nModifiedUsers = [...this.state.modifiedUsers].filter(
        (c) => c.email !== email
      );
      this.setState({ modifiedUsers: nModifiedUsers });
    } else {
      let nModifiedUsers = [...this.state.modifiedUsers];
      if (modifiedUserIndex >= 0) nModifiedUsers.slice(index, 1);
      nModifiedUsers.push({ email: user.email, roles: newRols });
      this.setState({ modifiedUsers: nModifiedUsers });
    }
  };

  handleAcceptChanges = () => {
    if (this.state.modifiedUsers.length > 0) {
      fetch("https://localhost:44313/api/User/Roles", {
        mode: "cors",
        headers: {
          "Content-Type": "application/json",
          Authorization:
            "Bearer " +
            JSON.parse(localStorage.getItem("loggedUser")).jwt_token,
        },
        method: "PATCH",
        body: JSON.stringify(this.state.modifiedUsers),
      })
        .then((response) => {
          if (!response.ok) {
            throw Error(response.statusText);
          }
          return response.json();
        })
        .catch(function (error) {
          console.log(
            "Hubo un problema con la petición Fetch:" + error.message
          );
        });
    }
    this.props.history.push("/");
  };

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
            {this.state.users.map((user, index) => (
              <tr id={user.username}>
                <td>{user.userName}</td>
                <td>{user.email}</td>
                <td>
                  <Form.Check
                    onChange={(e) =>
                      this.handleModifyUser(e, "Admin", user.email, index)
                    }
                    defaultChecked={user.roles.includes("Admin") ? true : false}
                  />
                </td>
                <td>
                  <Form.Check
                    onChange={(e) =>
                      this.handleModifyUser(e, "Accountant", user.email, index)
                    }
                    defaultChecked={
                      user.roles.includes("Accountant") ? true : false
                    }
                  />
                </td>
                <td>
                  <Form.Check
                    onChange={(e) =>
                      this.handleModifyUser(e, "Worker", user.email, index)
                    }
                    defaultChecked={
                      user.roles.includes("Worker") ? true : false
                    }
                  />
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
        <Button
          onClick={this.handleAcceptChanges}
          className="mt-3"
          style={{ float: "right" }}
        >
          Aceptar
        </Button>
      </Container>
    );
  }
}

export default WebMaster;
