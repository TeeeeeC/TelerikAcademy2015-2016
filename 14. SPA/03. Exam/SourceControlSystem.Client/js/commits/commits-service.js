(function () {
    'use strict';

    function commits($http, $q, $cookieStore, baseServiceUrl, authorization) {
        function getLast10Commits() {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/commits')
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function getCommitById(id) {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/commits/' + id, { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function addCommit(commit) {
            var deffered = $q.defer();

            $http.post(baseServiceUrl + '/api/commits', commit, { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        return {
            getLast10Commits: getLast10Commits,
            getCommitById: getCommitById,
            addCommit: addCommit
        }
    }

    angular.module('sourceControlApp.services')
        .factory('commits', ['$http', '$q', '$cookieStore', 'baseServiceUrl', 'authorization', commits]);
}());