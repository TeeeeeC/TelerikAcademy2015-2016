'use strict';

var tripExchangeApp = angular.module('tripExchangeApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'app/views/partials/home.html',
                controller: 'HomeCtrl'
            })
            .when('/register', {
                templateUrl: 'app/views/partials/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/trips', {
                templateUrl: 'app/views/partials/trips.html',
                controller: 'TripsCtrl'
            })
            .when('/drivers', {
                templateUrl: 'app/views/partials/drivers.html',
                controller: 'DriversCtrl'
            })
            .otherwise({ redirectTo: '/' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://spa2014.bgcoder.com');