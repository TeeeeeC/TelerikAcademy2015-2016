//Problem 1. Exchange if greater.
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

var a = 5.5,
    b = 4.5;

if (a > b) {

    console.log(b + ' ' + a);

} else {

    console.log(a + ' ' + b);

}

console.log('----------------------------');

//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

var a = -4,
    b = -2.5,
    c = 4;

if (a === 0 || b === 0 || c === 0) {

    console.log(a, b, c, '0')

} else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0)
    || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0)) {

    console.log(a, b, c, '-')

} else {

    console.log(a, b, c, '+')

}

console.log('----------------------------');

//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
//Use nested if statements.

var a = 5,
    b = 2,
    c = 4;

console.log(a, b, c);

if (a >= b) {

    if (a >= c) {

        console.log('Biggest = ', a);

    } else {

        console.log('Biggest = ', c);

    }

} else {

    if (b >= c) {

        console.log('Biggest = ', b);

    } else {

        console.log('Biggest = ', c);

    }

}

console.log('----------------------------');

//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

var a = -2,
    b = 4,
    c = 3;

console.log('Numbers: ', a, b, c);

if (a >= b && a >= c) {

    if (b >= c) {

        console.log('Sorted: ', a, b, c);

    } else {

        console.log('Sorted: ', a, c, b);

    }

} else if (b >= a && b >= c) {

    if (a >= c) {

        console.log('Sorted: ', b, a, c);

    } else {

        console.log('Sorted: ', b, c, a);

    }

} else {

    if (a >= b) {

        console.log('Sorted: ', c, a, b);

    } else {

        console.log('Sorted: ', c, b, a);

    }

}

console.log('----------------------------');

//Problem 5. Digit as word
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

var digit = Number(prompt('Enter digit: '));

switch(digit) {

    case 0: console.log(digit + ' -> zero'); break;
    case 1: console.log(digit + ' -> one'); break;
    case 2: console.log(digit + ' -> two'); break;
    case 3: console.log(digit + ' -> three'); break;
    case 4: console.log(digit + ' -> four'); break;
    case 5: console.log(digit + ' -> five'); break;
    case 6: console.log(digit + ' -> six'); break;
    case 7: console.log(digit + ' -> seven'); break;
    case 8: console.log(digit + ' -> eight'); break;
    case 9: console.log(digit + ' -> nine'); break;
    default: console.log('not a digit'); break;

}

console.log('----------------------------');

//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

do{

    a = Number(prompt('Enter coeff a = '));
    b = Number(prompt('Enter coeff b = '));
    c = Number(prompt('Enter coeff c = '));

} while(!(Number(a) && Number(b) && Number(c) || (a != 0 || b != 0 || c != 0)));

var d = (b * b) - (4 * a * c);

if (d < 0) {

    console.log(a, b, c, 'no real roots');

} else {

    if (d === 0) {

        console.log(a, b, c, 'x1=x2=' + (-1 * b) / (2 * a));

    } else {

        console.log(a, b, c, 'x1=' + ((-1 * b) + Math.sqrt(d)) / (2 * a), 'x2=' + ((-1 * b) - Math.sqrt(d)) / (2 * a));

    }

}

console.log('----------------------------');

//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

do{

    a = Number(prompt('Enter number a = '));
    b = Number(prompt('Enter number b = '));
    c = Number(prompt('Enter number c = '));
    d = Number(prompt('Enter number d = '));
    e = Number(prompt('Enter number e = '));

} while (!(Number(a) && Number(b) && Number(c) && Number(d) && Number(e) || (a != 0 || b != 0 || c != 0 || d != 0 || e != 0)));

if (a >= b && a >= c && a >= d && a >= e) {

    console.log(a, b, c, d, e);
    console.log('The biggest of 5 numbers is', a);

} else if (b >= a && b >= c && b >= d && b >= e) {

    console.log(a, b, c, d, e);
    console.log('The biggest of 5 numbers is', b);

} else if (c >= a && c >= b && c >= d && c >= e) {

    console.log(a, b, c, d, e);
    console.log('The biggest of 5 numbers is', c);

} else if (d >= a && d >= b && d >= c && d >= e) {

    console.log(a, b, c, d, e);
    console.log('The biggest of 5 numbers is', d);

} else  {

    console.log(a, b, c, d, e);
    console.log('The biggest of 5 numbers is', e);

}

console.log('----------------------------');

//Problem 8. Number as words
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var arrFromZeroToNineteen = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten', 'Eleven',
                            'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'],
    arrDivideBy10 = ['Ten', 'Twenty', 'Thirty', 'Fourty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'],
    arrDivideBy100 = ['A hundred', 'Two hundred', 'Three hundred', 'Four hundred', 'Five hundred', 'Six hundred', 'Seven hundred',
                    'Eight hundred', 'Nine hundred'];

for (var i = 0; i < 5; i++) {

    do {

        var number = Number(prompt('Enter number 5 times [0-999] ='));

    } while ((number < 0 || number > 999) || !(Number(number)))

    if (number < 20) {

        console.log(number + ' -> ' + arrFromZeroToNineteen[number]);

    } else if (number < 100) {

        if (number % 10 === 0) {

            console.log(number + ' -> ' + arrDivideBy10[(number / 10) - 1]);

        } else {
           
            console.log(number + ' -> ' + arrDivideBy10[Math.floor((number / 10) - ((number % 10) / 10) - 0.5)] + ' ' + arrFromZeroToNineteen[number % 10].toLowerCase());

        }

    } else {

        if (number % 100 === 0) {

            console.log(number + ' -> ' + arrDivideBy100[(number / 100) - 1]);

        } else if (number % 100 < 20) {

            console.log(number + ' -> ' + arrDivideBy100[Math.floor((number / 100) - ((number % 100) / 100) - 0.5)] + ' and ' + arrFromZeroToNineteen[number % 100].toLowerCase());

        } else {

            var remainder = number % 100;

            console.log(number + ' -> ' + arrDivideBy100[Math.floor((number / 100) - ((number % 100) / 100) - 0.5)] + ' and ' + arrDivideBy10[Math.floor((remainder / 10) - ((remainder % 10) / 10) - 0.5)].toLowerCase() + ' ' + arrFromZeroToNineteen[number % 10].toLowerCase());

        }

    }
}