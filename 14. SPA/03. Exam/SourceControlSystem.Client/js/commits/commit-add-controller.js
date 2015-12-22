(function () {
    'use strict';

    function CommitAddCtrl($scope, $routeParams, $location, commits, notifier) {
        $scope.addCommit = function (commit) {
            if (commit == undefined) {
                notifier.error("You should enter sorce code!")
            }

            var commitToAdd = {
                projectId: $routeParams.id,
                sourceCode: commit
            };

            commits.addCommit(commitToAdd)
                .then(function () {
                    notifier.success("You are created commit!");
                    $location.path('/projects/' + $routeParams.id);
                })
        }
    }

    angular.module('sourceControlApp.controllers')
        .controller('CommitAddCtrl', ['$scope', '$routeParams', '$location', 'commits', 'notifier', CommitAddCtrl]);
}());