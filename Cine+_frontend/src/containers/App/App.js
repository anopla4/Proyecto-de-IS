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

class App extends Component {
  // logginUserCallback = (username, password, jwt_token) => {
  //   localStorage.setItem(
  //     "loggedUser",
  //     JSON.stringify({
  //       username: username,
  //       password: password,
  //       jwt_token: jwt_token,
  //     })
  //   );
  // };

  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route path="/" exact component={Home} />
            <Route
              path="/login"
              component={() => (
                <Login onLoginCallback={this.logginUserCallback} />
              )}
            />
            <Route path="/register" component={Register} />
            <Route path="/reserve" component={Reserve} />
            <Route path="/myReservations" component={MyReservations} />
            <Route path="/filmScreenings" component={FilmScreenings} />
            <Route path="/movieScreenings" component={MoviesScreening} />
            <Route path="/films" component={Films} />
            <Route path="/filmForm" component={FilmForm} />
            <Route path="/filmScreeningForm" component={FilmScreeningForm} />
            <Route path="/top10Form" component={Top10Form} />
            <Route path="/purchaseOrder" component={PurchaseOrder} />
            <Route path="/clubMemberForm" component={ClubMemberForm} />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}

export default App;
