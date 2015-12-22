(function () {
    'use strict';

    function HomeCtrl($scope, stats, projects, commits) {
        stats.getStats()
           .then(function (data) {
               $scope.users = data.Users;
               $scope.projects = data.Projects;
               $scope.commits = data.Commits;
           });

        projects.getLast10Projects()
           .then(function (data) {
               $scope.last10Projects = data;
           });

        commits.getLast10Commits()
            .then(function (data) {
                $scope.last10Commits = data;
            });
    }

    angular.module('sourceControlApp.controllers')
        .controller('HomeCtrl', ['$scope', 'stats', 'projects', 'commits', HomeCtrl]);
}());