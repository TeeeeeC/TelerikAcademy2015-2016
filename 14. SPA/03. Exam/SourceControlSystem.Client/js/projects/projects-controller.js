(function () {
    'use strict';

    function ProjectsCtrl($scope, projects, identity) {
        $scope.identity = identity.isAuthenticated();

        $scope.req = {
            Page: 1
        };

        projects.getAllProjects()
            .then(function (data) {
                $scope.last10Projects = data;
            })

        $scope.prevPage = function (req) {
            if ($scope.req.Page == 1) {
                return;
            }

            $scope.req.Page--;
            projects.getAllProjects()
                .then(function (data) {
                    $scope.last10Projects = data;
                });
        }

        $scope.nextPage = function (req) {
            if (!$scope.last10Projects || $scope.last10Projects.length == 0) {
                return;
            }

            $scope.req.Page++;
            projects.getAllProjects()
                .then(function (data) {
                    $scope.last10Projects = data;
                });
        }

        $scope.filter = function (req) {
            projects.getAllProjects()
                .then(function (data) {
                    $scope.last10Projects = data;
                })
            }
    }

    angular.module('sourceControlApp.controllers')
        .controller('ProjectsCtrl', ['$scope', 'projects', 'identity', ProjectsCtrl]);
}());