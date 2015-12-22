(function () {
    'use strict';

    function projects($http, $q, $cookieStore, baseServiceUrl, authorization, identity) {
        function getLast10Projects() {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/projects')
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function getProjectDetails(projectId) {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/projects/' + projectId, { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function getAllProjects(params) {
            var deffered = $q.defer();
            var headers = identity.isAuthenticated() ? authorization.getAuthorizationHeader() : {}

            $http.get(baseServiceUrl + '/api/projects/all', { params: params, headers: headers })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function getProjectCollaborators(projectId) {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/projects/collaborators/' + projectId, { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function getProjectCommits(projectId, params) {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/commits/byproject/' + projectId, { params: params, headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        function addProject(project) {
            var deffered = $q.defer();

            $http.post(baseServiceUrl + '/api/projects', project, { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }


        function joinToProject(projectId, email) {
            var deffered = $q.defer();

            var headers = {
                'Authorization': authorization.getAuthorizationHeader().Authorization,
                'Content-Type': 'application/json'
            }

            var jsonEmail = JSON.stringify(email);

            $http.put(baseServiceUrl + '/api/projects/' + projectId, jsonEmail, { headers: headers })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        return {
            getLast10Projects: getLast10Projects,
            getProjectDetails: getProjectDetails,
            getAllProjects: getAllProjects,
            getProjectCollaborators: getProjectCollaborators,
            getProjectCommits: getProjectCommits,
            addProject: addProject,
            joinToProject: joinToProject
        }
    }

    angular.module('sourceControlApp.services')
        .factory('projects', ['$http', '$q', '$cookieStore', 'baseServiceUrl', 'authorization', 'identity', projects]);
}());