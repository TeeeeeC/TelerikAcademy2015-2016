/// <reference path="jquery-2.1.4.js">
function solve() {
    return function (selector) {
        var itemCount = 5,
            optinosValues = $(selector).find('option');
        $(selector).wrap('<div class="dropdown-list" />').hide();
        $('.dropdown-list').append('<div class="current" data-value="">Options</div>');
        $('.dropdown-list').css({
            'background': 'white'
        });

        $('.current').css({
            'color': 'black'
        });

        $('.dropdown-list').append('<div class="options-container" />');

        $('.options-container').css({
            'position': 'absolute',
            'display': 'none'
        }).hide();

        for (var i = 0; i < itemCount; i++) {
            $('<div class="dropdown-item" data-value="' + $(optinosValues[i]).val() + '" data-index="' + i + '">Option ' + (i + 1) + '</div>').appendTo('.options-container');
        }

        $('.current').on('click', function () {
            $('.options-container').show();
        });

        $('.options-container').on('click', '.dropdown-item', function (event) {
            $('.dropdown-list').css('display', 'none');
            $(selector).val($(this).attr('data-value'));
            $('.current').html($(this).html());
        });
    };
};

//module.exports = solve;

var module = solve();
module('#the-select');







