function sum() {
    return function (arr) {
        if(arr === undefined) {
            throw new Error();
        }
        var i,
            len = arr.length,
            result = 0;
        if (arr.length === 0) {
            return null;
        }

        for (i = 0; i < len; i += 1) {
            if (isNaN(+arr[i])) {
                throw new Error();
            }
            result += +arr[i];
        }

        return result;
    }
}

console.log(sum([1, 2, 3]));
console.log(sum([]));
//console.log(sum());
console.log(sum(['1', '2']));
//console.log(sum(['1', 'Jonh']));