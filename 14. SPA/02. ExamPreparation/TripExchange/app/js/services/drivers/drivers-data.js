'use strict';

tripExchangeApp.factory('driversData', ['$http', '$q', 'baseServiceUrl', function ($http, $q, baseServiceUrl) {
    var driversApi = baseServiceUrl + '/api/Drivers'

    return {
        getLatest10Drivers: function () {
            var deferred = $q.defer();
            $http({ method: 'GET', url: driversApi })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config) {
                    $log.error(data);
                    deferred.reject(data);
                });

            return deferred.promise;
        }
    }
}])