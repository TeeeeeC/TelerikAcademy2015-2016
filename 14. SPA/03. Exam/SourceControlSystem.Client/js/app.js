(function () {
    'use strict';

    function config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/partials/home/home.html',
                controller: 'HomeCtrl'
            })
            .when('/projects', {
                templateUrl: 'views/partials/projects/projects.html',
                controller: 'ProjectsCtrl'
            })
            .when('/projects/add', {
                templateUrl: 'views/partials/projects/project-add.html',
                controller: 'ProjectAddCtrl'
            })
            .when('/projects/:id/commits/add', {
                templateUrl: 'views/partials/commits/commit-add.html',
                controller: 'CommitAddCtrl'
            })
            .when('/projects/:id', {
                templateUrl: 'views/partials/projects/project-details.html',
                controller: 'ProjectDetailsCtrl'
            })
            .when('/commits/:id', {
                templateUrl: 'views/partials/commits/commit-details.html',
                controller: 'CommitDetailsCtrl'
            })
            .when('/register', {
                templateUrl: 'views/partials/identity/register.html',
                controller: 'RegisterCtrl'
            })
            .when('/unauthorized', {
                template: '<h1 class="text-center">YOU ARE NOT AUTHORIZED!</h1>'
            })
            .otherwise({ redirectTo: '/' });
    }

    angular.module('sourceControlApp.services', []);
    angular.module('sourceControlApp.directives', []);
    angular.module('sourceControlApp.filters', []);
    angular.module('sourceControlApp.controllers', ['sourceControlApp.services']);
    angular.module('sourceControlApp', ['ngRoute', 'ngCookies', 'ngSanitize', 'sourceControlApp.controllers', 'sourceControlApp.directives', 'sourceControlApp.filters', 'kendo.directives']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa.bgcoder.com');
}());