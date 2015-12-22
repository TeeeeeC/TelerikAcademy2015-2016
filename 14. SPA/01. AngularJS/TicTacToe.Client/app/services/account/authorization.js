(function () {
    'use strict';

    function Authorization(identity) {
        return {
            getAuthorizationHeader: function () {
                return {
                    'Authorization': 'Bearer ' + identity.getCurrentUser()['access_token'],
                }
            }
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('authorization', ['identity', Authorization]);
}())