//Problem 1. JavaScript literals
// Assign all the possible JavaScript literals to different variables.
var numberInt = 5,
    numberFloat = 5.2,
    symbol = 'g',
    isTrue = true,
    text = 'Pesho',
    literal = null,
    object = { name: 'gosho' },
    arr = [5, 'tosho'];
    
console.log('All literals: ' + numberInt + ', ' + numberFloat + ', ' + symbol + ', ' + isTrue + ', ' + text + '\n'
    + literal + ', ' + object.name +  ', ' + arr[0] + ', ' + arr[1]);
console.log('-------------');
    
//Problem 2. Quoted text
//Create a string variable with quoted text in it.
//For example: `'How you doin'?', Joey said'.
var text = "'How you doin'?', Joey said'.";
console.log(text);
console.log('-------------');

//Problem 3. Typeof variables
//Try typeof on all variables you created.
var numberInt = 5,
    numberFloat = 5.2,
    symbol = 'g',
    isTrue = true,
    text = 'Pesho',
    literal = null,
    object = { name: 'gosho' };

console.log(typeof numberInt, typeof numberFloat, typeof symbol, typeof isTrue, typeof text,
    typeof literal, typeof object);
console.log('-------------');

//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.
var reference = null;
var notUndefined;

console.log(typeof reference);
console.log(typeof notUndefined);
console.log('-------------');
