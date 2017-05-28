//Task 1
//function Solve(params) {
//    var N = parseInt(params[0]);
//    var numbers = [];
//    for (var i = 1; i <= N; i++) {
//        numbers[i] = parseInt(params[i]);
//    }

//    var maxSum = -2000000000;
//    for (var i = 1; i <= N; i++) {
//        for (var j = i; j <= N; j++) {
//            var localSum = 0;
//            for (var k = i; k <= j; k++) {
//                localSum += numbers[k];
//            }
//            if (localSum > maxSum) {
//                maxSum = localSum;
//            }
//        }
//    }

//    return maxSum;
//}

//console.log(Solve(6, 1, 3, -5, 8, 7, -6));
//console.log('------------------------');

//var nmStr = args[0].split(" ");
//var n = parseInt(nmStr[0]);
//var m = parseInt(nmStr[1]);
//var posStr = args[1].split(" ");
//var row = parseInt(posStr[0]);
//var col = parseInt(posStr[1]);
//var field = args.slice(2);

//Task 2
//function Solve(args) {
//    //args = [].slice.apply(arguments);

//    var sizeStr = args[0].split(' ');
//        rows = parseInt(sizeStr[0]),
//        cols = parseInt(sizeStr[1]),
//        posStr = args[1].split(' ');
//        row = parseInt(posStr[0]),
//        col = parseInt(posStr[1]),
//        matrix = [],
//        numberMatrix = [],
//        countPath = 0,
//        sum = 0,
//        passedPath = [],
//        index = 0,
//        number = 1;

//    for (var i = 2; i < args.length; i += 1) {
//        var line = args[i];
//        matrix[i - 2] = [];
//        numberMatrix[i - 2] = [];
//        for (var j = 0; j < line.length; j++) {
//            matrix[i - 2][j] = line[j];
//            numberMatrix[i - 2][j] = number;
//            number += 1;
//        }
//    }

//    while (true) {
//        if (row >= rows || row < 0 || col >= cols || col < 0) {
//            return 'out ' + sum;
//        }

//        var symbol = matrix[row][col];
//        for (var k = 0; k < passedPath.length - 1; k += 2) {
//            if (passedPath[k] === row && passedPath[k + 1] === col) {
//                return 'lost ' + countPath;
//            }
//        }

//        passedPath[index] = row;
//        index += 1;
//        passedPath[index] = col;
//        index += 1;
//        countPath += 1;
//        sum += numberMatrix[row][col];

//        switch (symbol) {
//            case 'l': col -= 1; break;
//            case 'r': col += 1; break;
//            case 'u': row -= 1; break;
//            case 'd': row += 1; break;
//        }
//    }
//}

//var test1 = "3 4", "1 3", "lrrd", "dlll", "rddd"
//"5 8","0 0","rrrrrrrd","rludulrd","durlddud","urrrldud","ulllllll"


//console.log(Solve("3 4", "1 3", "lrrd", "dlll", "rddd"));
//console.log(Solve("5 8", "0 0", "rrrrrrrd", "rludulrd", "durlddud", "urrrldud", "ulllllll"));
//console.log(Solve("5 8", "0 0", "rrrrrrrd", "rludulrd", "lurlddud", "urrrldud", "ulllllll"));

////Task 3
//function Solve(inputArr) {

//    var returnString = "",
//        definedFunctions = {};
//    for (var i = 0; i < inputArr.length; i++) {
//        //replace the called functions in the functions with their results
//        var firstRE = new RegExp(",", "g");
//        inputArr[i] = inputArr[i].replace(firstRE, " , ");
//        firstRE = new RegExp("\\[", "g");
//        inputArr[i] = inputArr[i].replace(firstRE, "[ ");
//        firstRE = new RegExp("\\]", "g");
//        inputArr[i] = inputArr[i].replace(firstRE, " ]");
//        for (var key in definedFunctions) {
//            var re = new RegExp(" " + key + " ", "g");
//            inputArr[i] = inputArr[i].replace(re, " " + definedFunctions[key] + " ");
//            inputArr[i] = inputArr[i].replace(re, " " + definedFunctions[key] + " ");
//        }

//        var splittedFunction = inputArr[i].split('['),
//         funcProps = GetFunctionProps(splittedFunction[0]);
//        //Check if the string line is a definition of a function
//        if (inputArr[i].indexOf("def ") !== -1) {
//            //split the function by "[" sign
//            definedFunctions[funcProps.funcName] = GetFunctionValue(funcProps.funcOperation, splittedFunction[1]);
//            //console.log(definedFunctions[funcProps.funcName])
//        }
//        if (i === inputArr.length - 1) {
//            returnString = GetFunctionValue(funcProps.funcOperation, splittedFunction[1]);
//        }
//    }
//    //console.log(definedFunctions);
//    return returnString;
//}

//function GetFunctionProps(functionString) {
//    var splittedFunctionString = functionString.split(' '),
//        returnObject = { funcName: "", funcOperation: "none" };
//    for (var i = splittedFunctionString.length - 1; i >= 0 ; i--) {
//        if (splittedFunctionString[i] === "sum" ||
//            splittedFunctionString[i] === "avg" ||
//            splittedFunctionString[i] === "min" ||
//            splittedFunctionString[i] === "max") {
//            returnObject.funcOperation = splittedFunctionString[i];
//        }
//        if (isNaN(splittedFunctionString[i]) &&
//            splittedFunctionString[i] !== "def" &&
//            splittedFunctionString[i] !== returnObject.funcOperation &&
//            splittedFunctionString[i].length > 0) {
//            returnObject.funcName = splittedFunctionString[i];
//        }
//    }
//    //console.log(returnObject);
//    return returnObject;
//}

//function GetFunctionValue(functionOperation, functionString) {
//    var newString = functionString.split(']');
//    if (functionOperation === "none") {
//        return newString[0].trim();
//    } else {
//        var splittedFunctionString = newString[0].split(','),
//            result = (functionOperation === 'min') ? Number.MAX_VALUE : 0,
//            count = 0,
//            number;
//        for (var i = 0; i < splittedFunctionString.length; i++) {
//            var numberString = splittedFunctionString[i].trim();
//            if (!isNaN(numberString) && numberString.length > 0) {
//                number = parseInt(numberString);
//                count++;
//                if (functionOperation === 'sum' || functionOperation === 'avg') {
//                    result = result + number;
//                } else if (functionOperation === 'max') {
//                    if (number > Number.MIN_VALUE && number > result) {
//                        result = number;
//                    }
//                } else if (functionOperation === 'min') {
//                    if (number < result) {
//                        result = number;
//                    }
//                }
//            }
//        }
//        if (functionOperation === 'avg') {
//            return parseInt(result / count);
//        }
//        return result;
//    }
//}

//var zeroTestArr = ['def func sum[5, 3, 7, 2, 6, 3]',
//                        'def func2 [5, 3, 7, 2, 6, 3]',
//                        'def func3 min[func2]',
//                        'def func4 max[5, 3, 7, 2, 6, 3]',
//                        'def func5 avg[5, 3, 7, 2, 6, 3]',
//                        'def func6 sum[func2, func3, func4 ]',
//                        'sum[func6, func4]']
////42
//var zeroTestArr1 = ['def func sum[1, 2, 3, -6]',
//                    'def newList [func, 10, 1]',
//                    'def newFunc sum[func, 100, newList]',
//                    '[newFunc]']
////111
//var testArr1 = ['def definition[-100, -100, -100]',
//                'def definitionResult sum[definition]',
//                'def defTest sum[definitionResult, 6457457, 2345234, -234546]',
//                'avg[defTest, 1, 2, 3]']

//console.log(Solve(zeroTestArr));
//console.log(Solve(zeroTestArr1));
//console.log(Solve(testArr1));

//Task1 Sequence
//function solve(args) {
//    var len = parseInt(args[0]),
//        countSeq = 1,
//        numbers = [];

//    for (var i = 1; i <= len; i++) {
//        numbers[i - 1] = parseInt(args[i]);
//    }

//    for (var i = 1; i < len; i++) {
//        if(numbers[i - 1] > numbers[i]) {
//            countSeq += 1;
//        } 
//    }
//    return countSeq;
//}

//console.log(solve(7, 1, 2, -3, 4, 4, 0, 1));
//console.log(solve(6, 1, 3, -5, 8, 7, -6));
//console.log(solve(9, 1, 8, 8, 7, 6, 5, 7, 7, 6)); 

//function solve(args) {
//    args = [].slice.apply(arguments);

//    var sizeStr = args[0].split(' '),
//        rows = parseInt(sizeStr[0]),
//        cols = parseInt(sizeStr[1]),
//        jumps = parseInt(sizeStr[2]),
//        posStr = args[1].split(' '),
//        row = parseInt(posStr[0]),
//        col = parseInt(posStr[1]),
//        countJump = 0,
//        sum = 0,
//        passedPath = [],
//        index = 0;

//    var indexOfCommand = 2,
//        line;
//    while (true) {
//        if (rows <= row || row < 0 || cols <= col || col < 0) {
//            return 'escaped ' + sum;
//        }

//        for (var k = 0; k < passedPath.length - 1; k += 2) {
//            if (passedPath[k] === row && passedPath[k + 1] === col) {
//                return 'caught ' + countJump;
//            }
//        }

//        passedPath[index] = row;
//        index += 1;
//        passedPath[index] = col;
//        index += 1;
//        sum += (row * (cols - 1)) + col + row + 1;

//        if (indexOfCommand === args.length) {
//            indexOfCommand = 2;
//        }
//        line = args[indexOfCommand].split(' ');
//        row += parseInt(line[0]);
//        col += parseInt(line[1]);
//        countJump += 1;
//        indexOfCommand += 1;
//    }
//}

//console.log(solve('6 7 3','0 0','2 2','-2 2','3 -1'));


//function solve(args) {
//    args = [].slice.apply(arguments);

//    function inRange(pos, range) {
//        return 0 <= pos && pos < range;
//    }

//    var nmkStr = args[0].split(" ");
//    var n = parseInt(nmkStr[0]);
//    var m = parseInt(nmkStr[1]);
//    var d = parseInt(nmkStr[2]);
//    var posStr = args[1].split(" ");
//    var row = parseInt(posStr[0]);
//    var column = parseInt(posStr[1]);
//    var dirsArr = args.slice(2);
//    var dirs = [dirsArr.length];
//    for (var i = 0; i < dirsArr.length; i++) {
//        var dir = dirsArr[i].split(" ");
//        dirs[i] = {
//            row: parseInt(dir[0]),
//            column: parseInt(dir[1])
//        }
//    }

//    var used = {};
//    var sum = 0;
//    var dir = 0;
//    var count = 0;
//    while (true) {
//        if (!inRange(row, n) || !inRange(column, m)) {
//            return "escaped " + sum;
//        }
//        if (used[row * m + column]) {
//            return "caught " + count;
//        }
//        count++;
//        used[row * m + column] = true;
//        sum += row * m + column + 1;
//        row += dirs[dir].row;
//        column += dirs[dir].column;
//        dir++;
//        dir %= dirs.length;
//    }
//}

//console.log(solve('6 7 3','0 0','2 2','-2 2','3 -1'));

//Problem 3 Clojure Parser

//function solve(args) {
//    args = [].slice.apply(arguments);



//    return args;
//}

//console.log(solve('( def         func       10)','(    def newFunc      (+  func 2))','(         def sumFunc   (+     func   func newFunc 0   0    0))','(  *    sumFunc 2   )'))

//function solve(params) {
//    //params = [].slice.apply(arguments);

//    var wheelCount = parseInt(params[0]);
//    var combinationsFound = 0;
//    var currentSolution;
//    for (var trucks = 0; trucks <= wheelCount / 10; trucks++) {
//        for (var cars = 0; cars <= wheelCount / 4; cars++) {
//            for (var trikes = 0; trikes <= wheelCount / 3; trikes++) {
//                currentSolution = trucks * 10 + cars * 4 + trikes * 3;
//                if (currentSolution === wheelCount) {
//                    combinationsFound++;
//                } else if (currentSolution > wheelCount) {
//                    break;
//                }
//            }
//        }
//    }
//    return combinationsFound;
//}

//console.log(solve(40));

//function solve(args) {
//    var sizeOfMatrix = args[0].split(' '),
//        rows = parseInt(sizeOfMatrix[0]),
//        cols = parseInt(sizeOfMatrix[1]),
//        row = 0,
//        col = 0,
//        commandMatrix = [],
//        boolMatrix = [],
//        sum = 0;

//    for (var i = 1; i < args.length; i++) {
//        var line = args[i].split(' ');
//        commandMatrix[i - 1] = [];
//        boolMatrix[i - 1] = [];
//        for (var j = 0; j < cols; j++) {
//            commandMatrix[i - 1][j] = line[j];
//            boolMatrix[i - 1][j] = false;
//        }
//    }

//    while(true) {
//        if (row >= rows || row < 0 || col >= cols || col < 0) {
//            return 'successed with ' + sum;
//        }

//        if(boolMatrix[row][col] === true) {
//            return 'failed at (' + row + ', ' + col + ')';
//        }

//        boolMatrix[row][col] = true;
//        sum += Math.pow(2, row) + col;

//        switch(commandMatrix[row][col]) {
//            case 'dr':
//                row += 1;
//                col += 1;
//                break;
//            case 'ur':
//                row -= 1;
//                col += 1;
//                break;
//            case 'dl':
//                row += 1;
//                col -= 1;
//                break;
//            case 'ul':
//                row -= 1;
//                col -= 1;
//                break;
//        }
//    }
//}

//console.log(solve([
//  '3 5',
//  'dr dl dr ur ul',
//  'dr dr ul ur ur',
//  'dl dr ur dl ur'
//]));
//console.log(solve([
//  '3 5',
//  'dr dl dl ur ul',
//  'dr dr ul ul ur',
//  'dl dr ur dl ur'
//]));

//function solve(params) {

//    var model = populateModel();
//    var result = parse();

//    function populateModel() {
//        var model = [];

//        for (var i = 1; i <= parseInt(params[0]) ; i++) {
//            var currentKeyValuePair = params[i].split('-');
//            var value;

//            if (currentKeyValuePair[1] === 'true') {
//                value = true;
//            }
//            else if (currentKeyValuePair[1] === 'false') {
//                value = false;
//            }
//            else if (currentKeyValuePair[1].indexOf(';') > -1) {
//                value = currentKeyValuePair[1].split(';');
//            }
//            else {
//                value = currentKeyValuePair[1];
//            }

//            model[currentKeyValuePair[0]] = value;
//        }

//        return model;
//    }

//    function parse() {
//        var startRow = parseInt(params[0]) + 2;

//        var result = [];
//        var sections = [];

//        var inNikolAngular = false;
//        var inTemplate = false;
//        var inCondition = false;
//        var inRepeater = false;
//        var inModel = false;
//        var render = true;

//        var currentTemplate;
//        var currentCollection;
//        var currentIndexatorName;
//        var currentIndex = 0;
//        var currentRepeaterTemplate = '';
//        var currentModelKey = '';

//        var deleteLeadingWhiteSpace = 0;

//        for (var i = startRow; i < params.length; i++) {
//            var currentRow = params[i];
//            var newLine = true;

//            if (inCondition && currentRow.indexOf('</nk-if>') > -1) {
//                deleteLeadingWhiteSpace = 0;
//                inCondition = false;
//                render = true;
//                continue;
//            }

//            if (inRepeater && currentRow.indexOf('</nk-repeat') > -1) {
//                currentRepeaterTemplateWithIndexator = currentRepeaterTemplate.split('<nk-model>' + currentIndexatorName + '</nk-model>').join(currentCollection[currentIndex++]);
//                var templateWhiteSpace = getLeadingWhiteSpace(currentRow);
//                result.push(currentRepeaterTemplateWithIndexator.substr(templateWhiteSpace).trim() + '\n');
//                for (var k = 1; k < currentCollection.length; k++) {
//                    currentRepeaterTemplateWithIndexator = currentRepeaterTemplate.split('<nk-model>' + currentIndexatorName + '</nk-model>').join(currentCollection[currentIndex++]);
//                    result.push(templateWhiteSpace + currentRepeaterTemplateWithIndexator.trim() + '\n');
//                }
//                currentCollection = undefined;
//                currentIndexatorName = undefined;
//                currentRepeaterTemplate = '';
//                currentIndex = 0;
//                inRepeater = false;
//                continue;
//            }

//            if (inCondition || inRepeater) {
//                deleteLeadingWhiteSpace += 4;
//            }

//            if (!render) {
//                continue;
//            }

//            if (deleteLeadingWhiteSpace > 0) {
//                currentRow = currentRow.substr(deleteLeadingWhiteSpace);
//                deleteLeadingWhiteSpace = 0;
//            }

//            if (inNikolAngular && inTemplate && currentRow.indexOf('</nk-') < 0) {
//                sections[currentTemplate].push(currentRow.substr(4) + '\n');
//                continue;
//            }

//            if (inNikolAngular && inTemplate && currentRow.indexOf('</nk-') > -1) {
//                inNikolAngular = false;
//                inTemplate = false;
//                continue;
//            }

//            for (var j = 0; j < currentRow.length; j++) {
//                var symbol = currentRow[j];

//                if (j + 1 < currentRow.length && (currentRow.substr(j, 2) == '{{' || currentRow.substr(j, 2) == '}}')) {
//                    j++;
//                    continue;
//                }

//                if (j + 3 < currentRow.length && currentRow.substr(j, 4) == '<nk-') {
//                    if (currentRow.indexOf('{{') < 0) {
//                        inNikolAngular = true;
//                        j += 3;
//                        continue;
//                    }
//                }

//                if (inNikolAngular && j + 14 < currentRow.length && currentRow.substr(j, 15) == 'template name="' && !inModel) {
//                    inTemplate = true;
//                    newLine = false;
//                    initializeTemplate(currentRow);
//                    break;
//                }

//                if (inNikolAngular && j + 16 < currentRow.length && currentRow.substr(j, 17) == 'template render="' && !inModel) {
//                    var templateToRender = getTemplate(currentRow);
//                    result.push(templateToRender);
//                    newLine = false;
//                    inNikolAngular = false;
//                    break;
//                }

//                if (inNikolAngular && j + 11 < currentRow.length && currentRow.substr(j, 12) == 'if condition' && currentRow.indexOf('>') > -1 && !inModel) {
//                    var parameter = getConditionalParameter(currentRow);
//                    var evaluatedCondition = !!model[parameter];
//                    deleteLeadingWhiteSpace = getLeadingWhiteSpace(currentRow).length;
//                    if (!evaluatedCondition) {
//                        render = false;
//                        deleteWhiteSpaceFromResult(deleteLeadingWhiteSpace);
//                    }
//                    inCondition = true;
//                    inNikolAngular = false;
//                    newLine = false;
//                    break;
//                }

//                if (inNikolAngular && j + 9 < currentRow.length && currentRow.substr(j, 10) == 'repeat for' && currentRow.indexOf('>') > -1 && !inModel) {
//                    var parameters = getForeachParameters(currentRow);
//                    currentCollection = model[parameters.collection];
//                    currentIndexatorName = parameters.indexator;
//                    inRepeater = true;
//                    inNikolAngular = false;
//                    newLine = false;
//                    break;
//                }

//                if (inNikolAngular && inModel && symbol == '<') {
//                    currentModelKey = currentModelKey.substr(6);
//                    var modelValue = model[currentModelKey];
//                    if (inRepeater && currentModelKey == currentIndexatorName) {
//                        currentRepeaterTemplate += '<nk-model>' + currentIndexatorName + '</nk-model>';
//                    }
//                    else if (inRepeater) {
//                        currentRepeaterTemplate += modelValue;
//                    }
//                    else {
//                        result.push(modelValue);
//                    }

//                    j += 10;
//                    currentModelKey = '';
//                    inNikolAngular = false;
//                    inModel = false;
//                    continue;
//                }

//                if (inNikolAngular) {
//                    currentModelKey += symbol;
//                    inModel = true;
//                    continue;
//                }

//                if (!inNikolAngular && inRepeater) {
//                    currentRepeaterTemplate += symbol;
//                    newLine = false;
//                    continue;
//                }

//                result.push(symbol);
//            }

//            if (inRepeater) {
//                currentRepeaterTemplate += '\n';
//            }
//            else if (newLine) {
//                result.push('\n');
//            }
//        }

//        return result.join('');

//        function initializeTemplate(currentRow) {
//            var templateParts = currentRow.split('"');
//            currentTemplate = templateParts[1];
//            sections[currentTemplate] = [];
//        }

//        function getTemplate(currentRow) {
//            var rendertemplateParts = currentRow.split('"');
//            var templateName = rendertemplateParts[1];
//            var leadingWhiteSpace = getLeadingWhiteSpace(currentRow);
//            return sections[templateName].join(leadingWhiteSpace);
//        }

//        function getConditionalParameter(currentRow) {
//            var param = currentRow.split('"')[1];
//            return param;
//        }

//        function getForeachParameters(currentRow) {
//            var params = currentRow.split('"')[1].split(' ');
//            return {
//                collection: params[2],
//                indexator: params[0]
//            };
//        }

//        function getLeadingWhiteSpace(currentRow) {
//            var whiteSpace = '';
//            for (var i = 0; i < currentRow.length; i++) {
//                if (currentRow[i] == ' ') {
//                    whiteSpace += ' ';
//                }
//                else {
//                    break;
//                }
//            }

//            return whiteSpace;
//        }

//        function checkIfLetter(symbol) {
//            var asciiCode = symbol.charCodeAt(0);
//            if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
//                return true;
//            }
//            return false;
//        }

//        function deleteWhiteSpaceFromResult(count) {
//            for (var i = 0; i < count; i++) {
//                result.pop();
//            }
//        }
//    }

//    return result;
//}

//console.log(solve(['6',
//'title:Telerik Academy',
//'showSubtitle:true',
//'subTitle:Free training',
//'showMarks:false',
//'marks:3,4,5,6',
//'students:Pesho,Gosho,Ivan',
//'42',
//'@section menu {',
//'<ul id="menu">',
//'    <li>Home</li>',
//'    <li>About us</li>',
//'</ul>',
//'}',
//'@section footer {',
//'    <footer>',
//'        Copyright Telerik Academy 2014',
//'    </footer>',
//'}',
//'<!DOCTYPE html>\n',
//'<html>\n',
//'<head>\n',
//'    <title>Telerik Academy</title>\n',
//'</head>\n',
//'<body>\n',
//'    @renderSection("menu")\n\n',

//'    <h1>@title</h1>\n',
//'    @if (showSubtitle) {\n',
//'        <h2>@subTitle</h2>\n',
//'        <div>@@JustNormalTextWithDoubleKliomba ;)</div>\n',
//'   }\n\n',

//'    <ul>\n',
//'        @foreach (var student in students) {\n',
//'            <li>\n',
//'                @student\n',
//'            </li>\n',
//'            <li>Multiline @title</li>\n',
//'        }\n',
//'</ul>\n',
//'    @if (showMarks) {\n',
//'        <div>\n',
//'            @marks\n',
//'        </div>\n',
//'    }\n\n',

//'    @renderSection("footer")\n',
//'</body>\n',
//'</html>\n']));

//function solve(a) {
//    return a[0] > 0 ? a[1] > 0 ? 1 : 3 : a[1] > 0 ? 0 : 2;
//}

//console.log(solve([-1, -2]));
//console.log(solve([1, -2]));
//console.log(solve([-1, 2]));
//console.log(solve([1, 2]));

//function solve(params) {
//    var money = parseInt(params[0]),
//        cake1 = parseInt(params[1]),
//        cake2 = parseInt(params[2]),
//        cake3 = parseInt(params[3]),
//        maxSpentMoney = 0;

//    for (var i = 0; i <= (money / cake1) + 1; i++) {
//        for (var j = 0; j <= (money / cake2) + 1; j++) {
//            for (var k = 0; k <= (money / cake3) + 1; k++) {
//                var currMoney = (cake1 * i) + (cake2 * j) + (cake3 * k);
//                if (currMoney <= money && currMoney > maxSpentMoney) {
//                    maxSpentMoney = currMoney;
//                }
//                else {
//                    break;
//                }
//            }
//        }
//    }

//    return maxSpentMoney;
//}

////console.log(solve([5, 13, 15, 17]));
////console.log(solve([20, 11, 200, 300]));
////console.log(solve([110, 19, 29, 39]));
//console.log(solve([1000, 198, 298, 398]));

//function solve(args) {
//	var sizes = args[0].split(' ').map(Number),
//		field = args.slice(1).map(function (row) {
//			return row.split('').map(Number);
//		}),
//		rows = sizes[0],
//		cols = sizes[1],
//		row = rows - 1,
//		col = cols - 1,
//		used = {},
//		jumps,
//		sum,
//		directions = [{}, {
//			row: -2,
//			col: 1
//		}, {
//			row: -1,
//			col: 2
//		}, {
//			row: 1,
//			col: 2
//		}, {
//			row: 2,
//			col: 1
//		}, {
//			row: 2,
//			col: -1
//		}, {
//			row: 1,
//			col: -2
//		}, {
//			row: -1,
//			col: -2
//		}, {
//			row: -2,
//			col: -1
//		}, ];
//	var line = [];
//	for (var c = 0; c < cols; c += 1) {
//		var value = c.toString();
//		while (value.length < 5) {
//			value = ' ' + value;
//		}
//		line.push(value);
//	}
//	function getValue(row, col) {
//		return (1 << row) - col;
//	}

//	function hash(row, col, cols) {
//		return row * cols + col;
//	}

//	function inRange(value, border) {
//		return 0 <= value && value < border;
//	}

//	jumps = 0;
//	sum = 0;
//	while (true) {
//		if (used[hash(row, col, cols)]) {
//			return 'Sadly the horse is doomed in ' + jumps + ' jumps';
//		}
//		if (!inRange(row, rows) || !inRange(col, cols)) {
//			return 'Go go Horsy! Collected ' + sum + ' weeds';
//		}

//		used[hash(row, col, cols)] = true;

//		jumps++;
//		sum += getValue(row, col);

//		var dirIndex = field[row][col],
//			dir = directions[dirIndex];

//		row += dir.row;
//		col += dir.col;
//	}
//}

//console.log(solve([
//  '3 5',
//  '54561',
//  '43328',
//  '52388',
//]));

//function solve(args) {
//    var numbers = args[0].split(', ').map(Number),
//        numOfPatterns = parseInt(args[1]),
//        maxSum = -Infinity,
//        lenOfNumbers = numbers.length;

//    for (var i = 0; i < numOfPatterns; i += 1) {
//        var lineNumbers = args[i + 2].split(', '),
//            lenOfLineNumbers = lineNumbers.length,
//            numbersBoolean = [],
//            index = 0,
//            indexOfPattern = 0,
//            sum = 0;


//        while (true) {
//            if (index < 0 || index >= lenOfNumbers) {
//                break;
//            }

//            if (numbersBoolean[index] === true) {
//                break;
//            }

//            sum += numbers[index];
//            numbersBoolean[index] = true;
//            index += parseInt(lineNumbers[indexOfPattern]);
//            indexOfPattern += 1;
//            if (indexOfPattern === lenOfLineNumbers) {
//                indexOfPattern = 0;
//            }
//        }

//        if (sum > maxSum) {
//            maxSum = sum;
//        }
//    }

//    return maxSum;
//}
//console.log(solve(['-185, -707, 428, 329, -149, -704, 27, 152, -704, 973, 806, 914, 653, 298, 538, 157, -165, 94, 79, 784, 570, 638, -738, -30, 174, 727, 102, 66, -574, -869, -413, 488, 979, -125, 261, -412, -81, 637, -980, 160, -279, -537, -853',
//'37',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0',
//'0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0'
//]))
//console.log(solve(['1, 3, -6, 7, 4 , 1, 12',
//'3',
//'1, 2, -3',
//'1, 3, -2',
//'1, -1']));

//function solve(args) {
//    var lines = parseInt(args[0]),
//        width = parseInt(args[1]),
//        text = args.slice(2),
//        words = [];

//    for (var i = 0; i < lines; i++) {
//        var line = text[i] + ' ',
//            word = '';
//        for (var j = 0; j < line.length; j++) {
//            if (line[j] !== ' ') {
//                word += line[j];
//            } else {
//                if (word !== '') {
//                    words.push(word);
//                }
//                word = '';
//            }
//        }
//    }

//    var currLineLen = 0,
//        index = 0,
//        startIndex = 0,
//        addSpaces = 0,
//        result = '';
//    while (index < words.length) {
//        currLineLen += words[index].length + 1;
//        if (currLineLen > width || index === words.length - 2) {
//            var countWords = index - startIndex - 1;

//            if (currLineLen - 1 > width && index !== words.length - 2) {
//                currLineLen -= words[index].length + 2;
//                index -= 1;
//            }
//            else {
//                currLineLen -= 1;
//            }

//            var allSpaces = width - currLineLen + countWords,
//                spaces = Math.floor(allSpaces / countWords),
//                addSpaces = allSpaces % countWords;

//            for (var k = startIndex; k <= index; k += 1) {
//                result += words[k] + (k !== index ? strRepeat(' ', spaces) : '');
//                if (addSpaces > 0) {
//                    result += ' ';
//                    addSpaces -= 1;
//                }
//            }
//            result += '\n';
//            currLineLen = 0;
//            startIndex = index + 1;
//        }
//        index += 1;

//        if (index === words.length && currLineLen !== 0) {
//            for (var k = startIndex; k < index; k += 1) {
//                result += words[k] + (k !== index - 1 ? ' ' : '');
//            }
//            result += '\n';
//        }
//    }

//    function strRepeat(str, qty) {
//        if (qty < 1) return '';
//        var result = '';
//        while (qty > 0) {
//            if (qty & 1) result += str;
//            qty >>= 1, str += str;
//        }
//        return result;
//    }

//    return result;
//}

//console.log(solve(['5',
//'20',
//'We happy few        we band',
//'of brothers for he who sheds',
//'his blood',
//'with',
//'me shall be my brother'
//]));

//console.log('----------------');
//console.log(solve(['10','18',
//'Beer beer beer Im going for', 
//'   a',
//'beer',
//'Beer beer beer Im gonna',
//'drink some beer',
//'I love drinkiiiiiiiiing', 
//'beer',
//'lovely', 
//'lovely',
//'beer']));
//console.log(solve(['12','34',
//'Dovahkiin Dovahkiin naal ok zin los vahriin    Wah dein vokul mahfaeraak ahst vaal    Ahrk fin norok paal graan fod nust hon',
//'zindro zaan    Dovahkiin fah hin kogaan mu draal      Huzrah nu kul do od wah aan bok lingrah vod    Ahrk fin tey boziik fun do fin gein    Wo lostfron wah ney dov',
//'ahrk fin reyliik do jul    Voth',
//'aan suleyk wah ronit faal krein      Ahrk fin zul rok drey kod nau tol morokei frod    Rul lot Taazokaan motaad voth kein    Sahrot Thuum med aan tuz vey zeim hokoron pah    Ol fin Dovakiin komeyt ok rein      Chorus    Dovahkiin Dovahkiin naal ok zin los vahriin    Wah dein vokul mahfaeraak ahst vaal    Ahrk fin norok paal graan fod nust hon zindro zaan    Dovahkiin fah hin kogaan mu draal      Ahrk fin Kel lost prodah do ved viing ko fin krah    Tol',
//'fod zeymah win kein meyz fuundein    Alduin feyn do jun kruziik vokun staadnav    Voth aan bahlok wah diivon fin lein      Nuz aan sul fent alok fod fin vul dovah nok    Fen kos nahlot mahfaeraak ahrk ruz    Paaz Keizaal fen kos stin nol bein Alduin jot    Dovahkiin kos fin saviik do muz   ',
//'  Chorus    Dovahkiin Dovahkiin naal ok zin los vahriin    Wah dein vokul mahfaeraak ahst vaal    Ahrk fin norok paal graan fod nust hon zindro zaan    Dovahkiin fah hin kogaan mu draa    Lyrics in English   From httpwwwelyricsnet   Dragonborn Dragonborn by his honor is sworn    To keep evil forever at bay    And the fiercest foes rout when they hear triumphs shout    Dragonborn for your blessing we pray      Hearken now sons of snow to an age long ago    And the tale boldly told of the one    Who was kin to both wyrm and the races of man    With a power to rival the sun      And the voice he',
//'did wield on that glorious field    When great Tamriel shuddered with war    Mighty Thuum like a blade cut through enemies all    As the Dragonborn issued his roar      Dragonborn Dragonborn by his honor is sworn    To keep',
//'evil forever at bay    And the fiercest foes rout when they hear triumphs shout    Dragonborn for your blessing we pray',  
//' And the Scrolls have foretold of black wings in the cold    That when brothers wage war come unfurled    Alduin Bane of Kings ancient shadow unbound    With a hunger to swallow the world      But a day shall arise when the dark dragons lies    Will be silenced forever and then    Fair Skyrim will be free from foul Alduins maw    Dragonborn be the savior of men      Dragonborn Dragonborn by his honor is sworn    To',
//'keep evil forever at bay    And',
//'the fiercest foes rout when they hear triumphs',
//'shout    Dragonborn for your blessing we pray']));

//function solve(args) {
//    var str = args[0],
//        numbers = str.split(', ').map(Number),
//        len = numbers.length,
//        counter = 1,
//        used = [];

//    for (var i = 0; i < len; i += 1) {
//        used[i] = true;
//        for (var j = 1; j < len; j += 1) {
//            var currIndex = i,
//                step = j,
//                previousNum = numbers[i],
//                currCount = 1;
//            currIndex += step;
//            currIndex = currIndex % len;
//            while (previousNum < numbers[currIndex] && !used[currIndex]) {
//                used[currIndex] = true;
//                previousNum = numbers[currIndex];
//                currIndex += step;
//                currIndex = currIndex % len;
//                currCount += 1;
//            }

//            if (currCount > counter) {
//                counter = currCount;
//            }

//            used = [];
//        }
//    }

//    return counter;
//}

//console.log(solve(['1, -2, -3, 4, -5, 6, -7, -8']));
//console.log(solve(['1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0']));
//console.log(solve(['1, 1, 1']));

//function solve(args) {
//    var rows = parseInt(args[0]),
//        pattern = args[1],
//        code = args.slice(2),
//        len = code.length,
//        result = '',
//        countBracket = 0,
//        shouldPrintNewLine = false,
//        isFirstSymbol = true;

//    for (var i = 0; i < len; i += 1) {
//        var line = code[i],
//            currRowLen = line.length;

//        for (var j = 0; j < currRowLen; j += 1) {
//            var symbol = line[j];
//            if (shouldPrintNewLine && symbol != '{' && symbol != '}') {
//                result += '\n';
//                shouldPrintNewLine = false;
//                isFirstSymbol = true;
//            }

//            if (symbol == '{') {
//                if (!isFirstSymbol) {
//                    result += '\n';
//                }
//                result += strRepeat(pattern, countBracket);
//                result += symbol;
//                countBracket += 1;
//                shouldPrintNewLine = true;
//            }
//            else if (symbol == '}') {
//                countBracket -= 1;
//                result += '\n';
//                result += strRepeat(pattern, countBracket);
//                result += symbol;
//                shouldPrintNewLine = true;
//            }
//            else {
//                if (isFirstSymbol) {
//                    result += strRepeat(pattern, countBracket);
//                }

//                if (!(isFirstSymbol && symbol === ' ')) {
//                    if (!(j < currRowLen - 1 && symbol === ' ' && line[j + 1] === ' '))     {
//                        result += symbol;
//                    }
//                }
//                isFirstSymbol = false;

//                if (j === currRowLen - 1 && result[result.length - 1] !== '\n' && symbol != '{' && symbol != '}') {
//                    shouldPrintNewLine = true;
//                }
//            }
//        }
//    }

//    function strRepeat(str, qty) {
//        if (qty < 1) return '';
//        var newResult = '';
//        while (qty > 0) {
//            if (qty & 1) newResult += str;
//            qty >>= 1, str += str;
//        }
//        return newResult;
//    }

//    return result;
//}

//console.log(solve(['3',
//'>>',
//'{a{',
//'}',
//'}'
//]));
//console.log('-------');
//console.log(solve(['5',
//'....',
//'using System;    namespace Stars',
//'{class Program{',
//'static    string[] separators',
//'= new string[] { " " };}',
//'}'
//]));
//console.log(solve(['1',
//'__',
//'{}{}{}{}{}{}{}{}{{{}{}{}{}}}'
//]));

//function(p){return p[0]>0?p[1]>0?1:3:p[1]>0?0:2}

//console.log(s([-1, -2]));
//console.log(s([1, -2]));
//console.log(s([-1, 2]));
//console.log(s([1, 2]));

//function solve(params) {
//    // var s = params[0].split(' ').map(Number);
//    var result;
//    // Your solution here
//    // console.log(params);
//    var tempContent = params[0].split(' ');
//    // console.log(tempContent);
//    var array = [],
//        count = 1,
//        maxRocks = -1;
//    // console.log(array);
//    function arrStrToInt(arr) {
//        // body...
//        var d,
//            lenD = arr.length,
//            nA = [];
//        for (var d = 0; d < lenD; d += 1) {
//            nA[d] = arr[d] * 1;
//        }

//        return nA;
//    }
//    // console.log(arrStrToInt(tempContent))
//    array = arrStrToInt(tempContent);
//    // console.log(array);

//    function transfArray(array) {
//        // body...
//        var len = array.length,
//                arrN = new Array(len);

//        arrN[0] = 'p';  // first

//        for (var k = 1; k < len - 1; k++) {
//            // console.log(k)
//            if (array[k - 1] < array[k] && array[k] > array[k + 1]) {
//                arrN[k] = 'p';
//            } else {
//                arrN[k] = 'v';
//            }

//        }

//        arrN[len - 1] = 'p'; // last

//        return arrN;
//    }
//    // console.log(transfArray(array));

//    var changeA = transfArray(array);
//    // console.log(changeA);

//    for (var i = 0; i < changeA.length; i++) {
//        if (changeA[i] === 'p') {
//            if (count > maxRocks) {
//                maxRocks = count;
//            }
//            count = 1;
//        } else {
//            count += 1;
//        }
//    }

//    result = maxRocks;
//    console.log(result);
//}

//var tests = [
//    '5 1 7 4 8',
//    '5 1 7 6 3 6 4 2 3 8',
//    '10 1 2 3 4 5 4 3 2 1 10'
//];

//tests.forEach(function testing(line) {
//    solve(line);
//})

function solve(params) {
    var s = params[0].split(' ').map(Number);
    var len = s.length;
    var riseslen = 2;
    var i;
    var j;
    var maxRisesIndex = 0;
    var maxrises = [];
    var maxrocks = 0;
    var currentrocks = 0;
    for (var i = 0; i < len; i += 1) {
        if (i === 0) {
            maxrises[maxRisesIndex] = i;
            maxRisesIndex += 1;
        }
        else if (i === (len - 1)) {
            maxrises[maxRisesIndex] = i;
            maxRisesIndex += 1;

        }
        else if (s[i - 1] < s[i] && s[i + 1] < s[i]) {
            maxrises[maxRisesIndex] = i;
            maxRisesIndex += 1;
            riseslen += 1;
        }
    }
    for (var j = 0; j < riseslen ; j += 1) {
        if (j === 0) {
            currentrocks = Math.abs(maxrises[j] - maxrises[j + 1]);
            if (currentrocks > maxrocks) {
                maxrocks = currentrocks;
                currentrocks = 0;
            }
        }
        else if (j === riseslen - 1) {
            currentrocks = Math.abs(maxrises[j] - maxrises[j - 1]);
            if (currentrocks > maxrocks) {
                maxrocks = currentrocks;
                currentrocks = 0;
            }
        }
        else {
            currentrocks = Math.abs(maxrises[j] - maxrises[j - 1]);
            if (currentrocks > maxrocks) {
                maxrocks = currentrocks;
                currentrocks = 0;
            }
        }
    }

    return maxrocks;
}

console.log(solve(['5 1 7 4 8']));
console.log(solve(['5 1 7 6 3 6 4 2 3 8']));
console.log(solve(['10 1 2 3 4 5 4 3 2 1 10']));