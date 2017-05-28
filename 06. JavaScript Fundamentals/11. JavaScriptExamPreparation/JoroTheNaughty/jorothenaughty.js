function solve(args) {
    var sizeAndJumps = args[0].split(' '),
        rows = +sizeAndJumps[0],
        cols = +sizeAndJumps[1],
        countCommands = +sizeAndJumps[2],
        initialPoint = args[1].split(' '),
        row = +initialPoint[0],
        col = +initialPoint[1],
        len = args.length,
        used = {},
        sum = 0,
        jumps = 0,
        commands = [];

    
    for (var i = 2; i < len; i++) {
        var line = args[i].split(' '),
            obj = {};
        obj['row'] = +line[0];
        obj['col'] = +line[1];
        commands.push(obj);
    }

    for (var i = 0; i < countCommands; i += 1) {
        if (isOutOfRange(row, col)) {
            return 'escaped ' + sum;
        }

        if (used[hash(row, col, cols)]) {
            return 'caught ' + jumps;
        }

        jumps += 1;
        sum += (row * cols) + col + 1;
        used[hash(row, col, cols)] = true;
        row += commands[i].row;
        col += commands[i].col;

        if (i === countCommands - 1) {
            i = -1;
        }
    }

    function hash(row, col, cols) {
        return row * cols + col;
    }

    function isOutOfRange(currRow, currCol) {
        return currRow >= rows || currRow < 0 || currCol >= cols || currCol < 0;
    }
}

console.log(solve(['6 7 3',
'0 0',
'2 2',
'-2 2',
'3 -1'
]));