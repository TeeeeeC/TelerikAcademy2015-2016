'use strict';

tripExchangeApp.factory('tripsData', ['$http', '$q', 'baseServiceUrl', function ($http, $q, baseServiceUrl) {
    var tripsApi = baseServiceUrl + '/api/Trips'

    return {
        getLatest10Trips: function () {
            var deferred = $q.defer();
            $http({ method: 'GET', url: tripsApi })
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