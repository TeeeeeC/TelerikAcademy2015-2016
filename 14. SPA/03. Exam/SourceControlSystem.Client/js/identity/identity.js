(function () {
    'use strict';

    function identity($cookieStore) {
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
                    $cookieStore.put(cookieStorageUserKey, user);
                    $cookieStore.put(email, user.userName);
                }
                else {
                    $cookieStore.remove(cookieStorageUserKey);
                }

                currentUser = user;
            },
            isAuthenticated: function () {
                return !!this.getCurrentUser();
            }
        }
    }

    angular.module('sourceControlApp.services')
        .factory('identity', ['$cookieStore', identity]);
}());