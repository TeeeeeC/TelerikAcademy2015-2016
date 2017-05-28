function solve(args) {
    var len = parseInt(args[0]),
        countSeq = 1,
        numbers = [];
    
    for (var i = 1; i < len; i++) {
        numbers[i - 1] = parseInt(args[i]);
    }
        
    for (var i = 1; i < len; i++) {
        if(numbers[i - 1] > numbers[i]) {
            countSeq += 1;
        } 
    }

    return countSeq;
}

console.log(solve(7, 1, 2, -3, 4, 4, 0, 1));
console.log(solve(6, 1, 3, -5, 8, 7, -6));
console.log(solve(9, 1, 8, 8, 7, 6, 5, 7, 7, 6)); 