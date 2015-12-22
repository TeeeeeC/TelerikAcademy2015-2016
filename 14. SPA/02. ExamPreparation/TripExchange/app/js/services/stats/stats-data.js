'use strict';

tripExchangeApp.factory('statsData', ['$http', '$q', 'baseServiceUrl', function ($http, $q, baseServiceUrl) {
    var statsApi = baseServiceUrl + '/api/stats'
    var cache;

    return {
        getStats: function () {
            var deferred = $q.defer();
            if (cache == undefined) {
                $http({ method: 'GET', url: statsApi })
                    .success(function (data, status, headers, config) {
                        cache = {
                            tripsTotal: data.trips,
                            upcomingTrips: data.finishedTrips,
                            usersCount: data.users,
                            driversCount: data.drivers
                        }
                        deferred.resolve(data);
                    })
                    .error(function (data, status, headers, config) {
                        $log.error(data);
                        deferred.reject(data);
                    });

                return deferred.promise;
            }

            deferred.resolve(cache)

            return deferred.promise;
        }
    }
}])