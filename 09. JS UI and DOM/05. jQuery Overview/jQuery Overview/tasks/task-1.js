/// <reference path="jquery-2.1.4.min.js" />
/// <reference path="jquery-2.1.4.js" />
function solve() {
    return function (selector, count) {
        var $ul = $('<ul />').addClass('items-list');

        if (typeof selector != 'string') {
            throw new Error();
        }

        if (typeof count != 'number' || count < 1) {
            throw new Error();
        }

        for (var i = 0; i < count; i += 1) {
            var $li = $('<li />').text('List item #' + i);
            $ul.append($li);
        }

        $ul.find('li').addClass('list-item');

        $(selector).append($ul);
    };
};

module.exports = solve;

