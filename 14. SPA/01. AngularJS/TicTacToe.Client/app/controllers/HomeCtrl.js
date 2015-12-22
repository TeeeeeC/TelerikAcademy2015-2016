(function () {
    'use strict';

    function HomeCtrl($scope, $location, $timeout, notifier, identity, auth, game) {
        game.allGames()
            .then(function (games) {
                for (var i = 0; i < games.length; i++) {
                    switch(games[i].State)
                    {
                        case 0: games[i].State = 'WaitingForSecondPlayer'; break;
                        case 1: games[i].State = 'TurnX'; break;
                        case 2: games[i].State = 'TurnO'; break;
                        case 3: games[i].State = 'WonByX'; break;
                        case 4: games[i].State = 'WonByO'; break;
                        case 5: games[i].State = 'Draw'; break;
                    }
                }

                $scope.games = games;
            });

        $scope.join = function () {
            game.join()
                .then(function () {
                    $timeout(function () {
                        $location.path('/play');
                    })
                })
        };

        $scope.disableJoin = function (game) {
            if (identity.getCurrentEmail() === undefined) {
                return true;
            }

            var result = (game.SecondPlayer === null)
                && (identity.getCurrentEmail() === game.FirstPlayer.Email);
            
            return result;
        }

        $scope.showBtn = function (game) {
            if (game.State.indexOf("Won") > -1) {
                return 'View';
            }

            return 'Play';
        }

        $scope.showPlay = function (game) {
            var currUserEmail = identity.getCurrentEmail();
            
            var result = (game.SecondPlayer !== null) && (currUserEmail === game.FirstPlayer.Email || currUserEmail === game.SecondPlayer.Email)

            return result;
        }

        $scope.setCurrentGameId = function (gameId) {
            game.setCurrentGameId(gameId);
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('HomeCtrl', ['$scope', '$location', '$timeout', 'notifier', 'identity', 'auth', 'game', HomeCtrl]);
}())