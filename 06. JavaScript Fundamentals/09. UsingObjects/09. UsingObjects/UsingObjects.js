//Problem 1. Make person
//Write a functio for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

function createPerson(fname, lname, age, gender) {
    return {
        fname: fname,
        lname: lname,
        age: age,
        gender: gender === 'female' ? true : false

    };
}

var people = [
    createPerson('Pesho', 'Ivanov', 25, 'male'),
    createPerson('Tosho', 'Nikolov', 26, 'male'),
    createPerson('Gosho', 'Petrov', 55, 'male'),
    createPerson('Mara', 'Ivanova', 5, 'female'),
    createPerson('Miro', 'Iliev', 34, 'male'),
    createPerson('Pencho', 'Todorov', 42, 'male'),
    createPerson('Pena', 'Popinska', 23, 'female'),
    createPerson('Krasi', 'Stoichkov', 18, 'male'),
    createPerson('Daniela', 'Spasova', 29, 'female'),
    createPerson('Borislava', 'Petrova', 55, 'female')
];

console.log(people);
console.log('---------------------');

//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//    Use only array methods and no regular loops (for, while)

function minAge(min) {
    return function (item) {
        return item.age >= min;
    }
}

console.log(people.every(minAge(18)));
console.log('---------------------');

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

console.log(people.filter(minAge(18)));
console.log('---------------------');

//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

function isFemale(gender) {
    return function (item) {
        return !!item.gender;
    }
}

var counter = 0,
    sumAgeOfFemales = people.filter(isFemale(true))
                                .reduce(function (sum, number) {
                                    counter += 1;
                                    return sum + number.age;
                                }, 0),
    avgFemales = Math.floor((sumAgeOfFemales / counter + 0.5));

console.log(avgFemales);
console.log('---------------------');

//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

function isMale(gender) {
    return function (item) {
        return !item.gender;
    }
}

var sortPeopleByAge = people.sort(function (item1, item2) {
    return item1.age > item2.age;
}),
    youngestMale = sortPeopleByAge.find(isMale(false)),
    fullNameyoungestMale = youngestMale.fname + ' ' + youngestMale.lname;

console.log(sortPeopleByAge);
console.log(youngestMale);
console.log(fullNameyoungestMale);
console.log('---------------------');

//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

var sortPeopleByFirstLetterInFirstname = people.sort(function (item1, item2) {
    return item1.fname[0] > item2.fname[0]
}),
    groupPeopleByFirstLetterInFirstname = sortPeopleByFirstLetterInFirstname.reduce(function (obj, item) {
        if (obj[item.fname[0]]) {
            obj[item.fname[0]].push(item);
        } else {
            obj[item.fname[0]] = [item];
        }
        return obj;
    }, {});


console.log(groupPeopleByFirstLetterInFirstname);