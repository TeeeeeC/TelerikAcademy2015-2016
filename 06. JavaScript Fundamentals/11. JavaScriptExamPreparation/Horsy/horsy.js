function solve(args) {
    var sizeOfMatrix = args[0].split(' '),
        rows = parseInt(sizeOfMatrix[0]),
        cols = parseInt(sizeOfMatrix[1]),
        currRow = rows - 1,
        currCol = cols - 1,
        matrix = [],
        used = [],
        sum = 0
        countSteps = 0;

    var dir = [{},
        {
            row: -2,
            col: 1
        },
        {
            row: -1,
            col: 2
        },
        {
            row: 1,
            col: 2
        },
        {
            row: 2,
            col: 1
        },
        {
            row: 2,
            col: -1
        },
        {
            row: 1,
            col: -2
        },
        {
            row: -1,
            col: -2
        },
        {
            row: -2,
            col: -1
        }
    ];

    for (var i = 1; i < args.length; i += 1) {
        var line = args[i];
        matrix[i - 1] = [];
        used[i - 1] = [];
        for (var j = 0; j < line.length; j += 1) {
            matrix[i - 1][j] = parseInt(line[j]);
            used[i - 1][j] = false;
        }
    }

    while(true) {
        if (isOutOfRange(currRow, currCol)) {
            return 'Go go Horsy! Collected ' + sum + ' weeds';
            break;
        }

        if (used[currRow][currCol]) {
            return 'Sadly the horse is doomed in ' + countSteps + ' jumps';
            break;
        }

        var index = matrix[currRow][currCol],
            updateDir = dir[index];

        used[currRow][currCol] = true;
        countSteps += 1;
        sum += Math.pow(2, currRow) - currCol;
        currRow += updateDir.row;
        currCol += updateDir.col;
    }

    function isOutOfRange(currRow, col) {
        return currRow >= rows || currRow < 0 || currCol >= cols || currCol < 0;
    }
}

console.log(solve(['3 5',
  '54561',
  '43328',
  '52388'
]));
console.log(solve(['3 5',
  '54361',
  '43326',
  '52188'
]));