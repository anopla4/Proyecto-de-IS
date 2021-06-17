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

function formatDate(date) {
  let list = date.split("-").reverse();
  return list.join("-");
}

function formatDateRequest(date) {
  let d = new Date(date);
  return `${d.getFullYear()}-${d.getMonth() + 1}-${d.getDate()}`;
}

function compareList(m, n) {
  let a = [...m.sort()];
  let b = [...n.sort()];

  if (a.length !== b.length) return false;
  for (let index = 0; index < a.length; index++) {
    const ai = a[index];
    const bi = b[index];
    if (ai !== bi) return false;
  }
  return true;
}

function compareDates(d1, d2) {
  let a = this.formatDateRequest(d1.split("-").map((a) => parseInt(a, 10)));
  let b = this.formatDateRequest(d2.split("-").map((b) => parseInt(b, 10)));
  console.log(a, b);
  if (a[0] === b[0] && a[1] === b[1] && a[2] === b[2]) return true;
  return false;
}

module.exports = {
  groupBy,
  isLoggedIn,
  onlyUnique,
  formatDate,
  formatDateRequest,
  compareList,
  compareDates,
};
