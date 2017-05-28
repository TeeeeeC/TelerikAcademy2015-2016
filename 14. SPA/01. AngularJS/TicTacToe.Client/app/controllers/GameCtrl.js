(function () {
    'use strict';

    function GameCtrl($scope, $location, $timeout, game) {
        $scope.game = function () {
            game.create()
                .then(function (games) {
                    $timeout(function () {
                        $location.path('/');
                    })
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('GameCtrl', ['$scope', '$location', '$timeout', 'game', GameCtrl]);
}())