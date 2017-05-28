/// <reference path="jquery-2.1.4.min.js" />
/// <reference path="jquery-2.1.4.js" />
function solve() {
    return function (selector) {
        if (selector == undefined || typeof selector != 'string' || $(selector).length == 0) {
            throw new Error();
        }

        var allButtons = $('.button');
        var allContents = $('.content');

        $(allButtons).text('hide');
        $(allContents).css('display', '');

        $(selector).on('click', '.button', function (event) {
            var $this = $(event.target),
                next = $this;

            while (next.length > 0) {
                next = next.next();
                if ($(next).hasClass('content')) {
                    break;
                }
            }

            if (next.css('display') == 'none') {
                next.css('display', '');
                $this.text('hide');
            }
            else {
                next.css('display', 'none');
                $this.text('show');
            }
        });
    };
};


module.exports = solve;

