(function () {
    'use strict';

    function licenses($http, $q, baseServiceUrl, authorization) {
        function getLicenses() {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/licenses', { headers: authorization.getAuthorizationHeader() })
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        return {
            getLicenses: getLicenses
        }
    }

    angular.module('sourceControlApp.services')
        .factory('licenses', ['$http', '$q', 'baseServiceUrl', 'authorization', licenses]);
}());