(function () {
    'use strict';

    function Notifier(toastr) {
        return {
            success: function (msg) {
                toastr.success(msg);
            },
            error: function (msg) {
                toastr.error(msg);
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('notifier', ['toastr', Notifier]);
}())