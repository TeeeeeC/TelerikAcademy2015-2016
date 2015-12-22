(function () {
    'use strict';

    function Auth($http, $q, identity, authorization, baseServiceUrl) {
        var usersApi = baseServiceUrl + '/api/account'

        return {
            signup: function (user) {
                var deferred = $q.defer();

                $http.post(usersApi + '/register', user)
                    .success(function () {
                        deferred.resolve();
                    }, function (response) {
                        deferred.reject(response);
                    });

                return deferred.promise;
            },
            login: function (user) {
                var deferred = $q.defer();
                user['grant_type'] = 'password';
                $http.post(baseServiceUrl + '/token', 'username=' + user.username + '&password=' + user.password + '&grant_type=password', { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                    .success(function (response) {
                        if (response["access_token"]) {
                            var userNameAndToken = {
                                token: response,
                                username: user.username
                            }
                            identity.setCurrentUser(userNameAndToken);
                            deferred.resolve(true);
                        }
                        else {
                            deferred.resolve(false);
                        }
                    });

                return deferred.promise;
            },
            logout: function () {
                identity.setCurrentUser(undefined);
            },
            isAuthenticated: function () {
                if (identity.isAuthenticated()) {
                    return true;
                }
                else {
                    return $q.reject('not authorized');
                }
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('auth', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl', Auth]);
}())