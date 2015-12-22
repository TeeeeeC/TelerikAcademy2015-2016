(function () {
    'use strict';

    function SignUpCtrl($scope, $location, auth, notifier) {
        $scope.signup = function (user) {
            auth.signup(user).then(function () {
                notifier.success('Registration successful!');
                $location.path('/');
            })
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('SignUpCtrl', ['$scope', '$location', 'auth', 'notifier', SignUpCtrl]);
}())