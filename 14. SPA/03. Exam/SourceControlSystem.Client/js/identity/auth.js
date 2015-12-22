(function () {
    'use strict';

    function auth($http, $q, $location, identity, authorization, baseServiceUrl) {
        var usersApi = baseServiceUrl + '/api/account'

        return {
            signup: function (user) {
                var deferred = $q.defer();

                $http.post(usersApi + '/register', user)
                    .then(function () {
                        deferred.resolve();
                    }, function (response) {
                        deferred.reject(response.message);
                    });

                return deferred.promise;
            },
            login: function (user) {
                var deferred = $q.defer();
                user['grant_type'] = 'password';
                $http.post(baseServiceUrl + '/token', 'username=' + user.username + '&password=' + user.password + '&grant_type=password', { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                    .then(function (response) {
                        if (response.data["access_token"]) {
                            identity.setCurrentUser(response.data);
                            $location.path('/');
                            deferred.resolve(true);
                        }
                        else {
                            deferred.resolve(false);
                        }
                    });

                return deferred.promise;
            },
            logout: function () {
                var deferred = $q.defer();

                var headers = authorization.getAuthorizationHeader();
                $http.post(usersApi + '/logout', {}, { headers: headers })
                    .then(function () {
                        identity.setCurrentUser(undefined);
                        $location.path('/');
                        deferred.resolve();
                    });

                return deferred.promise;
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

    angular.module('sourceControlApp.services')
        .factory('auth', ['$http', '$q', '$location', 'identity', 'authorization', 'baseServiceUrl', auth]);
}());