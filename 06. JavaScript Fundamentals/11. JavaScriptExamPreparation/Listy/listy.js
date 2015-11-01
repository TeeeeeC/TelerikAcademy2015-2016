function solve(args) {
    var rows = args.length;
    functions = [];

    //Parse input
    for (var i = 0; i < rows; i += 1) {
        var currRow = args[i],
            currRowLen = currRow.length,
            currWord = '',
            func = {
                name: '',
                operation: '',
                parameters: [],
                value: []
            },
            isDefinedFunction = false,
            functionNameFound = false,
            parametersFound = false;
        for (var j = 0; j < currRowLen; j += 1) {
            var symbol = currRow[j];

            if (currWord === 'def' && !isDefinedFunction) {
                currWord = '';
                isDefinedFunction = true;
                continue;
            }
            else if (isDefinedFunction && currWord != '' && symbol === ' ') {
                func.name = currWord;
                isDefinedFunction = false;
                functionNameFound = true;
                currWord = '';
            }
            else if (parametersFound && currWord !== '' && (symbol === ' ' || symbol === ',' || symbol === ']')) {
                if (!isNaN(currWord)) {
                    func.parameters.push(parseInt(currWord));
                    currWord = '';
                }
                else {
                    func.parameters.push(currWord);
                    currWord = '';
                }
            }
            else if (symbol === ' ' || symbol === ',') {
                continue;
            }
            else if (symbol === '[') {
                if (currWord !== '') {
                    func.operation = currWord;
                    currWord = '';
                }
                parametersFound = true;
            }
            else {
                currWord += symbol;
            }
        }

        functions.push(func);
    }

    //Evaluate result
    var funcLen = functions.length;
    for (var p = 0; p < funcLen; p++) {
        var currFunc = functions[p];
        if (currFunc.operation !== '') {
            currFunc.value = evaluateOperation(currFunc.operation, currFunc.parameters);
        }
        else {
            currFunc.value = [];
            for (var x = 0; x < currFunc.parameters.length; x++) {
                if (isNaN(currFunc.parameters[x])) {
                    currFunc.value[x] = getResultFromPreviosFunction('', currFunc.parameters[x]);
                }
                else {
                    currFunc.value[x] = currFunc.parameters[x];
                }
            }
        }
    }

    function evaluateOperation(operation, parameters) {
        var len = parameters.length,
            result = operation === 'min' ? Infinity : (operation === 'max' ? -Infinity : 0);
        for (var k = 0; k < len; k++) {
            var currValue = parameters[k];
            if (isNaN(currValue)) {
                currValue = getResultFromPreviosFunction(operation, currValue);
            }
            switch (operation) {
                case 'sum': result += currValue; break;
                case 'min': result = Math.min(result, currValue); break;
                case 'max': result = Math.max(result, currValue); break;
                case 'avg': result += currValue; break;
            }
        }

        if (operation === 'avg') {
            result = Math.floor(result / len);
        }

        return result;
    }

    function getResultFromPreviosFunction(operation, funcName) {
        var currResult = operation === 'min' ? Infinity : (operation === 'max' ? -Infinity : 0),
            isArr = true,
            counter = 0;
        for (var u = 0; u < funcLen; u += 1) {
            if (funcName === functions[u].name) {
                if (!Array.isArray(functions[u].value)) {
                    isArr = false;
                    counter += 1;
                }
                for (var v = 0; v < (functions[u].value.length !== undefined ? functions[u].value.length : counter) ; v += 1) {
                    var currValue = 0;
                    if (isArr) {
                        currValue = functions[u].value[v];
                    }
                    else {
                        currValue = functions[u].value;
                    }
                    switch (operation) {
                        case 'sum': currResult += currValue; break;
                        case 'min': currResult = Math.min(currResult, currValue); break;
                        case 'max': currResult = Math.max(currResult, currValue); break;
                        case 'avg': currResult += currValue; break;
                        default: currResult = currValue;
                    }
                }


                if (operation === 'avg') {
                    currResult = Math.floor(currResult / functions[u].parameters.length);
                }
                break;
            }
        }

        return currResult;
    }

    if (!Array.isArray(functions[funcLen - 1].value)) {
        return functions[funcLen - 1].value;
    }
    else {
        return functions[funcLen - 1].value[0];
    }
    
}

console.log(solve(['def func sum[5, 3,      7,2, 6, 3]',
'def      func2 [5, 3,      7, 2, 6, 3]',
'def func3     min[func2]',
'def func4 max[5, 3,7, 2, 6, 3]',
'def func5 avg[5, 3, 7, 2, 6, 3]',
'def     func6     sum[func2, func3, func4 ]',
'sum[func6, func4]'
]));
console.log(solve(['def func sum[1, 2, 3, -6]',
'def newList [func, 10, 1]',
'def newFunc sum[func, 100, newList]',
'[newFunc]'
]));