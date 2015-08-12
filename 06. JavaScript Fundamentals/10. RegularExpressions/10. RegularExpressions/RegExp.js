//Problem 1. Format with placeholders
//    Write a function that formats a string. The function should have placeholders, as shown in the example
//    Add the function to the String.prototype

String.prototype.format = function (options) {
    var result = this;
    for (var prop in options) {
        var reg = new RegExp('#{' + prop + '}');
        result = result.split(reg).join(options[prop]);
    }

    return result;
}

var options = { name: 'John' },
    options1 = { name: 'John', age: 13 };

console.log('Hello, there! Are you #{name}?'.format(options));
console.log('My name is #{name} and I am #{age}-years-old'.format(options1));
console.log('----------------');

//Problem 2. HTML binding
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//Add the function to the String.prototype

String.prototype.bind = function (str, obj) {
    var result = str + '';
    for (var prop in obj) {
        result = result.split(prop).join(obj[prop]);
        result = result.split(/></).join('>' + obj[prop] + '<');
    }

    return result;
}

var str = '<div data-bind-content="name"></div>',
    bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'

console.log(str.bind(str, { name: 'Steven' }));
console.log(str.bind(bindingString, { name: 'Elena', link: 'http://telerikacademy.com' }));