(function () {
    'use strict';

    function CommitDetailsCtrl($scope, $routeParams, $location, commits, notifier) {
        commits.getCommitById($routeParams.id)
            .then(function (data) {
                $scope.commit = data;
            });
    }

    angular.module('sourceControlApp.controllers')
        .controller('CommitDetailsCtrl', ['$scope', '$routeParams', '$location', 'commits', CommitDetailsCtrl]);
}());