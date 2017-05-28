(function () {
    function Game($http, $q, $cookieStore, identity, authorization, baseServiceUrl) {
        var gameApi = baseServiceUrl + '/api/games';

        return {
            create: function () {
                var deferred = $q.defer();
                var headers = {
                    'Authorization': authorization.getAuthorizationHeader().Authorization,
                    'Content-Type': 'application/x-www-form-urlencoded'
                }
  
                $http.post(gameApi + '/create', {}, { headers: headers })
                    .success(function (data) {
                        deferred.resolve(data);
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            },
            allGames: function () {
                var deferred = $q.defer();

                $http.get(gameApi)
                    .success(function (data) {
                        deferred.resolve(data);
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            },
            join: function () {
                var deferred = $q.defer();
                var headers = {
                    'Authorization': authorization.getAuthorizationHeader().Authorization,
                    'Content-Type': 'application/x-www-form-urlencoded'
                }

                var data = {};

                $http.post(gameApi + '/join', data, { headers: headers })
                    .success(function (data) {
                        deferred.resolve(data);
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            },
            setCurrentGameId: function (currGameId) {
                $cookieStore.put('currGameId', currGameId);
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('game', ['$http', '$q', '$cookieStore', 'identity', 'authorization', 'baseServiceUrl', Game]);
}())