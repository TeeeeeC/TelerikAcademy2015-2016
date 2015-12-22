(function () {
    'use strict';

    function beautifulDate() {
        return function (input) {

            var monthNames = [
              "Jan",
              "Feb",
              "Mar",
              "Apr",
              "May",
              "Jun",
              "Jul",
              "Aug",
              "Sep",
              "Oct",
              "Nov",
              "Dec"
            ];

            var date = new Date(input);
            var day = date.getDate();
            var monthIndex = date.getMonth();
            var year = date.getFullYear();
            var hour = date.getHours();
            var minutes = date.getMinutes();
            var seconds = date.getSeconds()
            var amPM = hour > 12 ? 'PM' : 'AM'

            return monthNames[monthIndex] + ' ' + day + '.' + year + ' ' + hour + ':' + minutes + ':' + seconds + ' ' + amPM;
        }
    }

    angular.module('sourceControlApp.filters')
        .filter('beautifulDate', [beautifulDate])
}());