(function () {
    'use strict';

    function config($routeProvider, $httpProvider) {
        $routeProvider
                .when('/', {
                    templateUrl: 'app/views/home.html',
                    controller: 'HomeCtrl'
                })
                .when('/register', {
                    templateUrl: 'app/views/accounts/register.html',
                    controller: 'SignUpCtrl'
                })
                .when('/create', {
                    templateUrl: 'app/views/games/game.html',
                    controller: 'GameCtrl'
                })
                .when('/play', {
                    templateUrl: 'app/views/games/play.html',
                    controller: 'PlayCtrl'
                })
                .otherwise({ redirectTo: '/' });
    }

    angular.module('ticTacToeApp.controllers', []);
    angular.module('ticTacToeApp.services', []);

    angular.module('ticTacToeApp', ['ticTacToeApp.controllers', 'ticTacToeApp.services', 'ngRoute', 'ngResource', 'ngCookies'])
        .config(['$routeProvider', '$httpProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://localhost:33257');
}())