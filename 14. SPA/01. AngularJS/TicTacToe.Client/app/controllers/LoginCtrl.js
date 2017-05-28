(function () {
    'use strict';

    function LoginCtrl($scope, $location, $timeout, notifier, identity, auth) {
        $scope.identity = identity;

        $scope.login = function (user, loginForm) {
            if (loginForm.$valid) {
                auth.login(user).then(function (success) {
                    if (success) {
                        notifier.success('Successful login!');
                    }
                    else {
                        notifier.error('Username/Password combination is not valid!');
                    }
                });
            }
            else {
                notifier.error('Username and password are required fields!')
            }
        }

        $scope.logout = function () {
            auth.logout();
            notifier.success('Successful logout!');
            if ($scope.user) {
                $scope.user.email = '';
                $scope.user.username = '';
                $scope.user.password = '';
            }

            $scope.loginForm.$setPristine();
            $timeout(function () {
                $location.path('/');
            });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('LoginCtrl', ['$scope', '$location', '$timeout', 'notifier', 'identity', 'auth', LoginCtrl]);
}())