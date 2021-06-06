const isLoggedIn = () => {
    return localStorage.getItem("loggedUser");
}

export default isLoggedIn;

