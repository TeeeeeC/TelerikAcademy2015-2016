(function () {
    'use strict';

    function ProjectAddCtrl($scope, $location, projects, notifier, licenses) {
        licenses.getLicenses()
            .then(function (data) {
                $scope.licenses = data;
            })

        $scope.addProject = function (project) {
            projects.addProject(project)
                .then(function () {
                    notifier.success('The project is created!');
                    $location.path('/projects');
                })
        }
    }

    angular.module('sourceControlApp.controllers')
        .controller('ProjectAddCtrl', ['$scope', '$location', 'projects', 'notifier', 'licenses', ProjectAddCtrl]);
}());