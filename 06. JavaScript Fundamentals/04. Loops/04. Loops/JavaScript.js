//Problem 1. Numbers
//Write a script that prints all the numbers from 1 to N.

do{

    var numberN = Number(prompt('Enter number bigger than 1'));

} while (!(Number(numberN) && numberN > 1));

for (var i = 1; i <= numberN; i++) {
    console.log(i);
}

console.log('---------------------');

//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

do {

    var numberN = Number(prompt('Enter number bigger than 1'));

} while (!(Number(numberN) && numberN > 1));

for (var i = 1; i <= numberN; i++) {
    if ((i % 3 != 0) || (i % 7 != 0)) {
        console.log(i);
    }
}

console.log('---------------------');

//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.

var numbers = [5, -1, 5, 8, 20, -15, -3, 40, 3, 2, 1],
    max = numbers[0],
    min = numbers[0];

for (var i = 1; i < numbers.length; i++) {
    if (max < numbers[i]) {
        max = numbers[i];
    }

    if (min > numbers[i]) {
        min = numbers[i];
    }
}

console.log('Min: ' + min);
console.log('Max: ' + max);
console.log('---------------------');

//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
var smallest = 'zzzzzzzzzz',
    largest = 'aaaaaaaaaa',
    prop;

for (prop in document) {
    if (prop < smallest) {
        smallest = prop;
    }

    if (prop > largest) {
        largest = prop;
    }
}

console.log('Smallest prop in document is ' + smallest);
console.log('Largest prop in document is ' + largest);

smallest = 'zzzzzzzzzz';
largest = 'aaaaaaaaaa';

for (prop in window) {
    if (prop < smallest) {
        smallest = prop;
    }

    if (prop > largest) {
        largest = prop;
    }
}

console.log('Smallest prop in window is ' + smallest);
console.log('Largest prop in window is ' + largest);

smallest = 'zzzzzzzzzz';
largest = 'aaaaaaaaaa';

for (prop in navigator) {
    if (prop < smallest) {
        smallest = prop;
    }

    if (prop > largest) {
        largest = prop;
    }
}

console.log('Smallest prop in navigator is ' + smallest);
console.log('Largest prop in navigator is ' + largest);