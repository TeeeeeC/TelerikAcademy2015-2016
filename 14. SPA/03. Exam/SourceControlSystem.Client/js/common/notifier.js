(function () {
    'use strict';

    angular.module('sourceControlApp.services').factory('notifier', ['toastr', function (toastr) {
        return {
            success: function (msg) {
                toastr.success(msg);
            },
            error: function (msg) {
                toastr.error(msg);
            }
        }
    }])
}());