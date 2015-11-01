//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.

var firstNum = 3,
    secondNum = 2,
    thirdNum = -2,
    fourthNum = -1,
    fifthNum = 0;

console.log('Is number odd?');
console.log(firstNum, firstNum % 2 === 1);
console.log(secondNum, secondNum % 2 === 1);
console.log(thirdNum, thirdNum % 2 === 1);
console.log(fourthNum, fourthNum % 2 === 1 || fourthNum % 2 === -1); //for negative numbers
console.log(fifthNum, fifthNum % 2 === 1);
console.log('------------------------');

//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var firstNum = 3,
    secondNum = 0,
    thirdNum = 5,
    fourthNum = 7,
    fifthNum = 35,
    sixthNum = 140;

console.log('Divided by 7 and 5?');
console.log(firstNum, firstNum % 7 === 0 && firstNum % 5 === 0);
console.log(secondNum, secondNum % 7 === 0 && secondNum % 5 === 0);
console.log(thirdNum, thirdNum % 7 === 0 && thirdNum % 5 === 0);
console.log(fourthNum, fourthNum % 7 === 0 && fourthNum % 5 === 0); 
console.log(fifthNum, fifthNum % 7 === 0 && fifthNum % 5 === 0);
console.log(sixthNum, sixthNum % 7 === 0 && sixthNum % 5 === 0);
console.log('------------------------');

//Problem 3. Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.

var width = 3,
    height = 4,
    width1 = 2.5,
    height1 = 3,
    width2 = 5,
    height2 = 5;

console.log('Area = ', width, '*', height, '=', width * height);
console.log('Area = ', width1, '*', height1, '=', width1 * height1);
console.log('Area = ', width2, '*', height2, '=', width2 * height2);
console.log('------------------------');

//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var number = 9999799;
console.log('Is third digit 7?');
console.log('Number = ', number);
number /= 100;
console.log(Math.floor(number) % 10 === 7);
console.log('------------------------');

//Problem 5. Third bit
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

var number = 5543,
    position = 2;
console.log(number);
number = parseInt(number, 10).toString(2)
console.log(number);
console.log('Result = ', ((1 << position) & number) >> position);
console.log('------------------------');

//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

var x = 0,
    y = 1,
    x1 = -2,
    y1 = 0,
    x2 = -1,
    y2 = 2,
    x3 = 1.5,
    y3 = -1,
    x9 = -1.5,
    y9 = -1.5,
    x4 = 100,
    y4 = -30,
    x5 = 0,
    y5 = 0,
    x6 = 0.2,
    y6 = -0.8,
    x7 = 0.9,
    y7 = -1.93,
    x8 = 1,
    y8 = 1.655,
    r = 5;

console.log('P(' + x + ', ' + y + ') is within a circle K(O, 5) = ', (x * x) + (y * y) <= r * r);
console.log('P(' + x1 + ', ' + y1 + ') is within a circle K(O, 5) = ', (x1 * x1) + (y1 * y1) <= r * r);
console.log('P(' + x2 + ', ' + y2 + ') is within a circle K(O, 5) = ', (x2 * x2) + (y2 * y2) <= r * r);
console.log('P(' + x3 + ', ' + y3 + ') is within a circle K(O, 5) = ', (x3 * x3) + (y3 * y3) <= r * r);
console.log('P(' + x9 + ', ' + y9 + ') is within a circle K(O, 5) = ', (x9 * x9) + (y9 * y9) <= r * r);
console.log('P(' + x4 + ', ' + y4 + ') is within a circle K(O, 5) = ', (x4 * x4) + (y4 * y4) <= r * r);
console.log('P(' + x5 + ', ' + y5 + ') is within a circle K(O, 5) = ', (x5 * x5) + (y5 * y5) <= r * r);
console.log('P(' + x6 + ', ' + y6 + ') is within a circle K(O, 5) = ', (x6 * x6) + (y6 * y6) <= r * r);
console.log('P(' + x7 + ', ' + y7 + ') is within a circle K(O, 5) = ', (x7 * x7) + (y7 * y7) <= r * r);
console.log('P(' + x8 + ', ' + y8 + ') is within a circle K(O, 5) = ', (x8 * x8) + (y8 * y8) <= r * r);
console.log('------------------------');

//Problem 7. Is prime
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
var number = 37;

console.log('Is number = ' + number + ' prime ? ', (number == 2 || number == 3 || number == 5 || number == 7
    || number == 11) || (number % 2 !== 0 && number % 3 !== 0 && number % 5 !== 0 && number % 7 !== 0) && (number > 1));
console.log('------------------------');

//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

var a = .222,
    b = .333,
    h = .555;

console.log('Trapezoid area = ', ((a + b) / 2) * h);
console.log('------------------------');

//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var x = 2.5,
    y = 2,
    checkPoint = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (3 * 3)) && (!(((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1))));

console.log('P(' + x + ', ' + y + ') is inside K( (1,1), 3) and outside of R(top=1, left=-1, width=6, height=2)');
console.log(checkPoint ? 'yes' : 'no');