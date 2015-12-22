(function () {
    'use strict';

    function stats($http, $q, baseServiceUrl) {
        function getStats() {
            var deffered = $q.defer();

            $http.get(baseServiceUrl + '/api/statistics')
                .then(function (res) {
                    deffered.resolve(res.data);
                }, function (err) {
                    deffered.reject(err);
                })

            return deffered.promise;
        }

        return {
            getStats: getStats
        }
    }

    angular.module('sourceControlApp.services')
        .factory('stats', ['$http', '$q', 'baseServiceUrl', stats]);
}());