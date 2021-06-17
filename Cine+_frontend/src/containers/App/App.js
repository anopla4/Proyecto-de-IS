import "./App.css";
import { Component } from "react";
import { Route, Switch } from "react-router";
import { BrowserRouter } from "react-router-dom";
import Layout from "../../components/Layout/Layout";
import Home from "../../components/Home/Home";
import Login from "../../components/Login/Login";
import Register from "../../components/Register/Register";
import Reserve from "../../components/Reserve/Reserve";
import FilmScreenings from "../../components/FilmScreenings/FilmScreenings";
import MoviesScreening from "../../components/MoviesScreening/MoviesScreening";
import Films from "../../components/Films/Films";
import FilmForm from "../../components/FilmForm/FilmForm";
import FilmScreeningForm from "../../components/FilmScreeningForm/FilmScreeningForm";
import Top10Form from "../../components/Top10Form/Top10Form";
import PurchaseOrder from "../../components/PurchaseOrder/PurchaseOrder";
import MyReservations from "../../components/MyReservations/MyReservations";
import ClubMemberForm from "../../components/ClubMemberForm/ClubMemberForm";
import BookEntry from "../../components/BookEntry/BookEntry";
import WebMaster from "../../components/WebMaster/WebMaster";
import Payment from "../../components/Payment/Payment";
import { isLoggedIn } from "../../components/utils";

class App extends Component {
  logginUserCallback = (
    email,
    password,
    roles,
    jwt_token,
    id,
    username,
    isMember
  ) => {
    localStorage.setItem(
      "loggedUser",
      JSON.stringify({
        email: email,
        password: password,
        roles: roles,
        userId: id,
        username: username,
        jwt_token: jwt_token,
        isClubMember: isMember,
      })
    );
  };

  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route path="/" exact component={Home} />
            <Route
              path="/login"
              component={(props) => (
                <Login {...props} onLoginCallback={this.logginUserCallback} />
              )}
            />
            <Route path="/register" component={Register} />
            <Route
              path="/reserve"
              component={
                isLoggedIn()
                  ? Reserve
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/myReservations"
              component={
                isLoggedIn()
                  ? MyReservations
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/filmScreenings"
              component={
                isLoggedIn()
                  ? FilmScreenings
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/movieScreenings"
              component={
                isLoggedIn()
                  ? MoviesScreening
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/films"
              component={
                isLoggedIn()
                  ? Films
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/filmForm"
              component={
                isLoggedIn()
                  ? FilmForm
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/filmScreeningForm"
              component={
                isLoggedIn()
                  ? FilmScreeningForm
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/top10Form"
              component={
                isLoggedIn()
                  ? Top10Form
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/purchaseOrder"
              component={
                isLoggedIn()
                  ? PurchaseOrder
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/clubMemberForm"
              component={
                isLoggedIn()
                  ? ClubMemberForm
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/bookEntry"
              component={
                isLoggedIn()
                  ? BookEntry
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/webMaster"
              component={
                isLoggedIn()
                  ? WebMaster
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
            <Route
              path="/payment"
              component={
                isLoggedIn()
                  ? Payment
                  : (props) => (
                      <Login
                        {...props}
                        onLoginCallback={this.logginUserCallback}
                      />
                    )
              }
            />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}

export default App;
