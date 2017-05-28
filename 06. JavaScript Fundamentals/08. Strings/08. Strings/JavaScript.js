//Problem 1. Reverse string
//Write a JavaScript function that reverses a string and returns it.

function reverseString(str) {
    str = str || '';
    var result = '';
    for (var i = str.length - 1; i >= 0; i -= 1) {
        result += str[i];
    }

    return result;
}

var str = 'sample';

console.log(reverseString(str));
console.log('------------------------------');

//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

function checkCorrBrackets(expression) {
    expression = expression || '';
    var counter = 0,
        i;
    for (i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            counter += 1;
        } else if (expression[i] === ')') {
            counter -= 1;
        }

        if (counter < 0) {
            return expression + ' -> ' + false;
        }
    }

    if (counter === 0) {
        return expression + ' -> ' + true;
    }

    return expression + ' -> ' + false;
}

console.log(checkCorrBrackets('((a+b)/5-d)'));
console.log(checkCorrBrackets(')(a+b))'));
console.log(checkCorrBrackets('((a+b)/5-d'));
console.log('------------------------------');

//Problem 3. Sub-string in text
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function countSubstring(text, str) {
    text = text || '';
    str = str || '';

    var counter = 0,
        index = 0;
    while (true) {
        index = text.indexOf(str, index);
        if (index < 0) {
            break;
        }
        counter += 1;
        index += 1;
    }

    console.log('Text: ' + text);

    return 'Sub-string is: ' + str + ' -> ' + counter + ' times';
}

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

console.log(countSubstring(text, 'in'));
console.log('------------------------------');

//Problem 4. Parse tags
//You are given a text. Write a function that changes the text in all regions:
//<upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)

function parseTags(text) {
    text = text || '';
    for (var i = 0; i < 3; i += 1) {
        var startIndex = 0,
            endIndex = 0,
            openTag = '',
            closedTag = '';

        switch (i) {
            case 0:
                openTag = '<upcase>';
                closedTag = '</upcase>';
                break;
            case 1:
                openTag = '<lowcase>';
                closedTag = '</lowcase>';
                break;
            case 2:
                openTag = '<mixcase>';
                closedTag = '</mixcase>';
                break;
        }

        while (true) {
            startIndex = text.indexOf(openTag.toLowerCase(), startIndex);
            endIndex = text.indexOf(closedTag.toLowerCase(), endIndex);

            if (startIndex < 0) {
                break;
            }

            switch (i) {
                case 0:
                    text = text.replace(text.substring(startIndex, endIndex), text.substring(startIndex + 8, endIndex).toUpperCase());
                    text = text.replace(openTag.toLowerCase(), '');
                    text = text.replace(closedTag.toLowerCase(), '');
                    break;
                case 1:
                    text = text.replace(text.substring(startIndex, endIndex), text.substring(startIndex + 9, endIndex).toLowerCase());
                    text = text.replace(openTag.toLowerCase(), '');
                    text = text.replace(closedTag.toLowerCase(), '');
                    break;
                case 2:
                    var mixedText = text.substring(startIndex + 9, endIndex),
                        randomText = '';
                    for (var j = 0; j < mixedText.length; j++) {
                        if (Math.floor(Math.random() - 0.5) === 0) {
                            randomText += mixedText[j].toLowerCase();
                        } else {
                            randomText += mixedText[j].toUpperCase();
                        }
                    }

                    text = text.replace(text.substring(startIndex + 9, endIndex), randomText);
                    text = text.replace(openTag.toLowerCase(), '');
                    text = text.replace(closedTag.toLowerCase(), '');
                    break;
            }

            startIndex += 1;
            endIndex += 1;
        }
    }

    return text;
}

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

console.log(text);
console.log(parseTags(text));
console.log('------------------------------');

//Problem 5. nbsp
//Write a function that replaces non breaking white-spaces in a text with &nbsp;

function replaceNonBreakingSpace(text) {
    text = text || '';

    return text.split(' ').join('&nbsp;');
}

var text = 'Write a function that replaces non breaking white-spaces in a text.';

console.log(text);
console.log(replaceNonBreakingSpace(text));
console.log('------------------------------');

//Problem 6. Extract text from HTML
//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.

function extractTextFromHTML(text) {
    text = text || '';
    var result = '';
    for (var i = 0; i < text.length - 1; i++) {
        if (text[i] === '>') {
            i += 1;
            while (text[i] != '<') {
                result += text[i];
                i += 1;
            }
        }
    }

    return result;
}

var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>'

console.log(text);
console.log(extractTextFromHTML(text));
console.log('------------------------------');

//Problem 7. Parse URL
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.

function parseURL(url) {
    url = url || '';
    var index = url.indexOf(':', 0),
        nameOfProtocol = url.substring(0, index),
        nameOfServer = '',
        nameOfResource = '',
        counter = 0;
    for (; index < url.length; index++) {
        if (url[index] === '/') {
            counter += 1;

            if (counter === 3) {
                break;
            }
        } else if (url[index] != ':' && url[index] != ' ') {
            nameOfServer += url[index];
        }
    }

    nameOfResource = url.substring(index, url.length - 1);

    return {
        protocol: nameOfProtocol,
        server: nameOfServer,
        resource: nameOfResource
    };
}

var url = 'http://telerikacademy.com/Courses/Courses/Details/239'

console.log(url);
console.log(parseURL(url));
console.log('------------------------------');

//Problem 8. Replace tags
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

function replaceTags(text) {
    text = text || '';
    text = text.split('<a href="').join('[URL=');
    text = text.split('">').join(']');
    text = text.split('</a>').join('[/URL]');

    return text;
}

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(text);
console.log(replaceTags(text));
console.log('------------------------------');

//Problem 9. Extract e-mails
//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

//http://stackoverflow.com/questions/46155/validate-email-address-in-javascript
function extractEmail(text) {
    text = text || '';
    var re = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i,
        emails = text.split(' ');
    for (var i = 0; i < emails.length; i++) {
        if (re.test(emails[i])) {
            console.log(emails[i]);
        }
    }
}

var text = 'gosho@abv.bg p?#@pesho kiro_ivanov@dir.com';

extractEmail(text);
console.log('------------------------------');

//Problem 10. Find palindromes
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function extractPalindrom(text) {
    text = text || '';
    var words = text.split(/[\s,.:'"?!|;]+/),
        palindromes = [],
        isPalinrome = true,
        word,
        left,
        right;
    for (var j = 0; j < words.length; j++) {
        word = words[j];
        for (var i = 0; i < word.length; i++) {
            left = i;
            right = word.length - 1 - i;

            if(word[left] != word[right]) {
                isPalinrome = false;
            }
        }

        if(isPalinrome && word.length > 1) {
            palindromes.push(word);
        }
        isPalinrome = true;
    }

    return palindromes;
}

var text = 'Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".';

console.log(extractPalindrom(text));
console.log('------------------------------');

//Problem 11. String format
//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.
//var str = stringFormat('Hello {0}!', 'Peter');
//str = 'Hello Peter!';
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
//str = '1, Pesho, 1 text Gosho'

function stringFormat(format) {
    format = format || '';
    var countParams = arguments.length;
    if (countParams > 30) {
        return 'Parameters in function must be smaller than 31'
    }

    for (var i = 1; i <= arguments.length; i++) {
        format = format.split('{' + (i - 1) + '}').join(arguments[i]);
    }
    return format;
}

console.log(stringFormat('Hello {0}!', 'Peter'));
console.log(stringFormat('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));
console.log('------------------------------');

//Problem 12. Generate list
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
//    Example: HTML:
//<div data-type="template" id="list-item">
// <strong>-{name}-</strong> <span>-{age}-</span>
///div>
//    JavaScript:
//var people = [{name: 'Peter', age: 14},…];
//var tmpl = document.getElementById('list-item').innerHtml;
//var peopleList = generateList(people, template);
//peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

var people = [
    { name: 'Pesho', age: 24 },
    { name: 'Gosho', age: 25 },
    { name: 'Kolio', age: 25 },
    { name: 'Kiro', age: 32 },
    { name: 'Shkumbata', age: 31 }],
	template = document.getElementById('list-item').innerHTML;

function generateList() {
    var ul = document.createElement('ul');

    for (var ind in people) {
        var li = document.createElement('li');
        li.innerHTML = format(template, people[ind]);
        ul.appendChild(li);
    }
    document.body.appendChild(ul);
}

function format(string, person) {
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop] || '';
    });
}