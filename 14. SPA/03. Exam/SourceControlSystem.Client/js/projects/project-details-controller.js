(function () {
    'use strict';

    function ProjectDetailsCtrl($scope, $location, $routeParams, $route, identity, projects, notifier) {
        if (!identity.isAuthenticated()) {
            $location.path('/unauthorized');
        }

        $scope.req = {
            page: 1
        };

        $scope.id = $routeParams.id;

        projects.getProjectDetails($routeParams.id)
            .then(function (data) {
                $scope.project = data;
            });

        projects.getProjectCollaborators($routeParams.id)
            .then(function (data) {
                $scope.collaborators = data;
            });

        projects.getProjectCommits($routeParams.id)
            .then(function (data) {
                $scope.last10Commits = data;
            });


        $scope.prevPage = function (req) {
            if ($scope.req.page == 1) {
                return;
            }

            $scope.req.page--;
            projects.getProjectCommits($routeParams.id, req)
                .then(function (data) {
                    $scope.last10Commits = data;
                });
        }

        $scope.nextPage = function (req) {
            if (!$scope.last10Commits || $scope.last10Commits.length == 0) {
                return;
            }

            $scope.req.page++;
            projects.getProjectCommits($routeParams.id, req)
                .then(function (data) {
                    $scope.last10Commits = data;
                });
        }

        $scope.filter = function (req) {
            projects.getProjectCommits($routeParams.id, req)
                .then(function (data) {
                    $scope.last10Commits = data;
                });
        }



        $scope.joinToProject = function (email) {
            projects.joinToProject($routeParams.id, email)
                .then(function () {
                    notifier.success('You are joined to project!');
                    $route.reload();
                }, function (err) {
                    notifier.error(err.data.Message);
                })
        }

    }

    angular.module('sourceControlApp.controllers')
        .controller('ProjectDetailsCtrl', ['$scope', '$location', '$routeParams', '$route', 'identity', 'projects', 'notifier', ProjectDetailsCtrl]);
}());