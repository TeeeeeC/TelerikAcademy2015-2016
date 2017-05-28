(function () {
    'use strict';

    function lastProjects() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/last-projects-directive.html'
        }
    }

    angular.module('sourceControlApp.directives')
        .directive('lastProjects', [lastProjects]);
}());