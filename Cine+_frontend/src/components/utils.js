const isLoggedIn = () => {
  return localStorage.getItem("loggedUser");
};

const groupBy = (objects, keys) => {
  if (keys.length > 0) {
    let key_path = keys[0].split(".");
    let res = [];
    let unique = objects
      .map((obj) => indexFurther(obj, key_path))
      .filter(onlyUnique);
    unique.forEach((element) => {
      let items = objects.filter((c) => indexFurther(c, key_path) === element);
      let object = items[0][key_path[0]];
      items = groupBy(items, keys.slice(1));
      let obj = {};
      obj[key_path[0]] = object;
      obj["_items"] = items;
      res.push(obj);
    });
    return res;
  } else return objects;
};

const onlyUnique = (value, index, self) => {
  return self.indexOf(value) === index;
};

function indexFurther(object, key_path) {
  key_path.forEach((key) => {
    object = object[key];
  });
  return object;
}

let moviesFilter = [
  {
    id: 1,
    movie: {
      id: 1,
      name: "Cinema Paradiso",
      year: "1988",
      genre: { name: "Drama" },
      country: "Italia",
      imgPath: "src/images/cinemaParadiso.jpg",
    },
    date: "5/6/2021",
    time: "9:00",
  },
  {
    id: 2,

    movie: {
      id: 1,
      name: "Cinema Paradiso",
      year: "1988",
      genre: { name: "Drama" },
      country: "Italia",
      imgPath: "src/images/cinemaParadiso.jpg",
    },
    date: "5/6/2021",
    time: "10:00",
  },
  {
    id: 3,

    movie: {
      id: 2,
      name: "Cinema",
      year: "1988",
      genre: { name: "Drama" },
      country: "Italia",
      imgPath: "src/images/cinemaParadiso.jpg",
    },
    date: "5/6/2021",
    time: "10:00",
  },
];

function a(moviesFilter) {
  let moviesTemp = [
    ...moviesFilter.filter((c) => {
      if (c.movie.name.startsWith("Cinema")) return true;
      return false;
    }),
  ];
  return moviesTemp;
}

// console.log(a(moviesFilter));

// module.exports.groupBy = groupBy;
// module.exports.isLoggedIn = isLoggedIn;

module.exports = { groupBy, isLoggedIn, onlyUnique };
