(function () {
    'use strict';

    function lastCommits() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/last-commits-directive.html'
        }
    }

    angular.module('sourceControlApp.directives')
        .directive('lastCommits', [lastCommits]);
}());