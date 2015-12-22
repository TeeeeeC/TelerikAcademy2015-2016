(function () {
    'use strict';

    function PlayCtrl($scope, $location, $timeout, $route, play) {
        $scope.getResult = function (row, col) {
            play.sendPlayData(row, col)
                .then(function () {
                    $route.reload();
                })
        }

        play.getStatus()
            .then(function (data) {
                $scope.drawField = function (row, col) {
                    var board = data.Board;
                    $scope.playerInTurn = data.State == 1 ? data.FirstPlayerName : data.SecondPlayerName;
                    $scope.disableBtn = ((board[(row - 1) * 3 + col - 1] != '-') || play.disbleAllBtnUserNotInTurn(data.State, data.FirstPlayerName, data.SecondPlayerName)) ? true : false;
                    return board[(row - 1) * 3 + col - 1] != '-' ? board[(row - 1) * 3 + col - 1] : '';
                }

                $scope.turnStatusInGame = function () {
                    if (data.State > 2) {
                        $scope.playerInTurn = data.State == 3 ? data.FirstPlayerName : data.SecondPlayerName;
                        return 'Winner: ';
                    }

                    return 'Player in Turn: ';
                }
            })
    }

    angular.module('ticTacToeApp.controllers')
        .controller('PlayCtrl', ['$scope', '$location', '$timeout', '$route', 'play', PlayCtrl]);
}())