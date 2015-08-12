//Problem 1. Increase array members
//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

var arr = [];

for (var i = 1; i <= 20; i++) {
    arr[i] = i * 5;
}

console.log(arr.join(' '));
console.log('-------------------');

//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).

var arr1 = ['g', 'e', 'o', 'r', 'g', 'i'],
    arr2 = ['p', 'e', 's', 'h', 'o'],
    isFirst = false,
    isSecond = false;

for (var i = 0; i < arr1.length; i++) {
    if (arr1[i] < arr2[i]) {
        isFirst = true;
        break;
    }

    if (arr1[i] > arr2[i]) {
        isSecond = true;
        break;
    }
}

if (isFirst) {
    console.log('The first arr is smaller than the second', arr1.join(' '));
} else if (isSecond) {
    console.log('The second arr is smaller than the first', arr2.join(' '));
} else {
    console.log('The two arrays are equal');
}

console.log('-------------------');

//Problem 3. Maximal sequence
//Write a script that finds the maximal sequence of equal elements in an array.

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    len = 1,
    maxLen = 1,
    number = 0,
    currNum = sequence[0];

for (var i = 1; i < sequence.length; i++) {
    if (currNum === sequence[i]) {
        len++;

        if (maxLen < len) {
            maxLen = len;
            number = currNum;
        }
    } else {
        len = 1;
    }

    currNum = sequence[i];
}

console.log(Array(maxLen + 1).join(number + ', '));
console.log('-------------------');

//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.

var increasingSequence = [3, 2, 3, 4, 2, 2, 4],
    len = 1,
    maxLen = 1,
    bestStart = 0,
    bestEnd = 0,
    currNum = increasingSequence[0];

for (var i = 1; i < increasingSequence.length; i++) {
    if (currNum < increasingSequence[i]) {
        len++;

        if (maxLen < len) {
            maxLen = len;
            bestEnd = i;
            bestStart = bestEnd - maxLen + 1;
        }
    } else {
        len = 1;
    }

    currNum = increasingSequence[i];
}

var newArr = [],
    index = 0;

for (var i = bestStart; i <= bestEnd; i++) {
    var newNum = increasingSequence[i];
    newArr[index] = newNum;
    index++;
}


console.log(newArr.join(', '));
console.log('-------------------');

//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
var unsortedArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    temp;

console.log(unsortedArr.join(', '));

function SelectionSort(unsortedArr) {
    for (var i = 0; i < unsortedArr.length - 1; i++) {
        for (var j = i; j < unsortedArr.length; j++) {
            if (unsortedArr[i] >= unsortedArr[j]) {
                temp = unsortedArr[i];
                unsortedArr[i] = unsortedArr[j];
                unsortedArr[j] = temp;
            }
        }
    }
    var sortedArr = unsortedArr;

    return sortedArr;
}

console.log(SelectionSort(unsortedArr).join(', '));
console.log('-------------------');

//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.
var freqNumberArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    sortedArr = SelectionSort(freqNumberArr),
    len = 1,
    maxLen = 1,
    number = 0,
    currNum = sortedArr[0];

for (var i = 1; i < sortedArr.length; i++) {
    if (currNum === sortedArr[i]) {
        len++;

        if (maxLen < len) {
            maxLen = len;
            number = currNum;
        }
    } else {
        len = 1;
    }

    currNum = sortedArr[i];
}

console.log(number + ' (' + maxLen + ' times)');
console.log('-------------------');

//Problem 7. Binary search
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var binarySearchArr = [1, 2, 3, 4, 5, 6, 7, 8],
    left = 0,
    right = binarySearchArr.length - 1,
    element = Number(prompt('Press number:'));

function BinarySearchAlg(element) {
    while (left <= right) {
        var middle = Math.floor((right + left) / 2)

        if (binarySearchArr[middle] === element) {
            return middle;
        } else if (binarySearchArr[middle] < element) {
            left = middle + 1;
        } else {
            right = middle - 1; 
        }
    }

    return -1;
}

if (BinarySearchAlg(element) != -1) {
    console.log('arr[' + BinarySearchAlg(element) + '] = ' + element);
} else {
    console.log(BinarySearchAlg(element));
}

