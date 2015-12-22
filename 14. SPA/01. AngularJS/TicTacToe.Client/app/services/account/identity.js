(function () {
    'use strict';

    function Identity($cookieStore) {
        var cookieStorageUserKey = 'currentApplicationUser';
        var email = 'email';

        var currentUser;
        return {
            getCurrentUser: function () {
                var savedUser = $cookieStore.get(cookieStorageUserKey);
                if (savedUser) {
                    return savedUser;
                }

                return currentUser;
            },
            setCurrentUser: function (user) {
                if (user) {
                    $cookieStore.put(cookieStorageUserKey, user.token);
                    $cookieStore.put(email, user.username);
                }
                else {
                    $cookieStore.remove(cookieStorageUserKey);
                    $cookieStore.remove(email);
                }

                currentUser = user;
            },
            isAuthenticated: function () {
                return !!this.getCurrentUser();
            },
            getCurrentEmail: function () {
                return $cookieStore.get(email);
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('identity', ['$cookieStore', Identity]);
}())