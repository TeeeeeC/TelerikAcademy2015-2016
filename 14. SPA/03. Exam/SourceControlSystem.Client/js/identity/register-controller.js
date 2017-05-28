(function () {
    'use strict';

    function RegisterCtrl($scope, $location, auth, notifier) {
        $scope.signup = function (user) {
            auth.signup(user).then(function () {
                notifier.success('Registration successful!');
                $location.path('/');
            })
        }
    }

    angular.module('sourceControlApp.controllers')
        .controller('RegisterCtrl', ['$scope', '$location', 'auth', 'notifier', RegisterCtrl]);
}());