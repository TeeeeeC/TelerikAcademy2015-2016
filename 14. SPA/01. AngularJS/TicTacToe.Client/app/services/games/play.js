(function () {
    function Play($http, $q, $cookieStore, authorization, baseServiceUrl, game) {
        return {
            sendPlayData: function (row, col) {
                var deferred = $q.defer();
                var headers = {
                    'Authorization': authorization.getAuthorizationHeader().Authorization,
                    'Content-Type': 'application/json'
                }

                var data = {
                    row: row,
                    col: col,
                    gameId: $cookieStore.get('currGameId')
                }

                $http.post(baseServiceUrl + '/api/games/play', data, { headers: headers })
                    .success(function () {
                        deferred.resolve();
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            },
            getStatus: function () {
                var deferred = $q.defer();

                var headers = {
                    'Authorization': authorization.getAuthorizationHeader().Authorization,
                    'Content-Type': 'application/x-www-form-urlencoded'
                }

                $http.get(baseServiceUrl + '/api/games/status/' + $cookieStore.get('currGameId'), { headers: headers })
                    .success(function (data) {
                        deferred.resolve(data);
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            },
            disbleAllBtnUserNotInTurn: function (state, firstPlayer, secondPlayer) {
                if ((state === 1 && firstPlayer === $cookieStore.get('email'))
                    || (state === 2 && secondPlayer === $cookieStore.get('email')))
                {
                    return false;
                }

                return true;
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('play', ['$http', '$q', '$cookieStore', 'authorization', 'baseServiceUrl', 'game', Play]);
}())