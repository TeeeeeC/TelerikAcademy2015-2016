//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function buildPointOrLine(x1, y1, x2, y2) {
    if (arguments.length === 2) {
        var point = {
            x1: x1,
            y1: y1,

            toString: function toString() {
                return 'P(' + x1 + ', ' + y1 + ')';
            }
        };

        return point;
    } else if (arguments.length === 4) {
        var line = {
            x1: x1,
            y1: y1,
            x2: x2,
            y2: y2,

            calculateDistance: function calculateDistance() {
                return 'Distance is ' + Math.sqrt(Math.pow(x1 - x2, 2) + Math.pow(y1 - y2, 2));
            },

            toString: function toString() {
                return 'L(' + 'P1(' + x1 + ', ' + y1 + ')' + ', P2(' + x2 + ', ' + y2 + '))';
            }
        };

        return line;
    }
}

var point = buildPointOrLine(1, 3),
    line = buildPointOrLine(1, 1, 2, 1);

function checkThreeLinesFormTriangle() {
    var line1 = buildPointOrLine(1, 1, 2, 1),
        line2 = buildPointOrLine(2, 1, 2, 2),
        line3 = buildPointOrLine(2, 2, 1, 1);

    if (line1.x2 === line2.x1 && line1.y2 === line2.y1 && line2.x2 === line3.x1 && line2.y2 === line3.y1 && line3.x2 === line1.x1 && line3.y2 === line1.y1) {
        return true;
    }

    return false;
}

console.log(point.toString());
console.log(line.toString());
console.log(checkThreeLinesFormTriangle());
console.log('-----------------------------');

//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

Array.prototype.remove = function (number) {
    var newArr = [],
        currNum,
        index = 0;
    for (var i = 0; i < arr.length; i++) {
        currNum = arr[i];
        if (currNum != number || currNum === number.toString()) {
            newArr[index] = currNum;
            index += 1;
        }
    }

    return 'arr = [' + newArr.join(', ') + ']';
};

console.log(arr.remove(1));
console.log('-----------------------------');

//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function deepCopyOfObj(obj) {
    for(var prop in obj) {
        console.log(prop + ' -> ' + obj[prop]);
    }
}

var person = {
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 15,
    city: 'Sofia'
};

deepCopyOfObj(person);
console.log('-----------------------------');

//Problem 4. Has property
//Write a function that checks if a given object contains a given property.

function hasProperty(obj, propName) {
    for (var prop in obj) {
        if(prop === propName) {
            return propName + ' ' + true;
        }
    }

    return propName + ' ' + false;
}

console.log(hasProperty(person, 'age'));
console.log(hasProperty(person, 'town'));
console.log('-----------------------------');

//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

function getYoungestPerson(people) {
    var age = 1000,
        youngest = {};
    for (var i = 0; i < people.length; i += 1) {
        var obj = people[i];
        for (var prop in obj) {
            if (prop === 'age' && obj[prop] < age) {
                age = obj[prop];
                youngest = obj;
            }
        }
    }

    return youngest.firstname + ' ' + youngest.lastname;
}

var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Tosho', lastname: 'Ivanov', age: 16 },
  { firstname: 'Pesho', lastname: 'Pureto', age: 84 },
  { firstname: 'Ico', lastname: 'Spicata', age: 34 },
  { firstname: 'Pepa', lastname: 'Kostova', age: 45 },
];

console.log(getYoungestPerson(people));
console.log('-----------------------------');

//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)

function group(people, key) {
    var associativeArray = {};
    for (var i in people) {
        var assoProperty = people[i][key];
        associativeArray[assoProperty] = [];
        for (var k in people) {
            if (assoProperty === people[k][key]) {
                associativeArray[assoProperty].push(people[k]);
            }
        }
    }
    return associativeArray;
}

var peopleArr = [
  { firstname: 'gosho', lastname: 'petrov', age: 32 },
  { firstname: 'bay', lastname: 'ivanov', age: 81 },
  { firstname: 'tosho', lastname: 'ivanov', age: 16 },
  { firstname: 'gosho', lastname: 'pureto', age: 16 },
  { firstname: 'ico', lastname: 'spicata', age: 34 },
  { firstname: 'pepa', lastname: 'kostova', age: 16 },
];

console.log(group(peopleArr, 'firstname'));
console.log(group(peopleArr, 'lastname'));
console.log(group(peopleArr, 'age'));
