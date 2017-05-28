/// <reference path="jquery-2.1.4.js">
/// <reference path="handlebars-v3.0.3.js">
function solve() {
    return function () {
        $.fn.listview = function (data) {
            var tempate = this.attr('data-template'),
                html = $('#' + tempate).html(),
                article = handlebars.compile(html);

            for (var i = 0, length = data.length; i < length; i += 1) {
                this.append(article(data[i]));
            }
            
            return this;
        };
    };
}

module.exports = solve;









