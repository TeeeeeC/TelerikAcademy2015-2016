'use strict';

tripExchangeApp.controller('HomeCtrl', function ($scope, tripsData, driversData, statsData) {
    tripsData.getLatest10Trips()
        .then(function (trips) {
            $scope.trips = trips.sort(function (a, b) {
                if (a.departureDate < b.departureDate) {
                    return -1;
                }

                if (a.departureDate > b.departureDate) {
                    return 1;
                }

                return 0;
            });
        });

    driversData.getLatest10Drivers()
        .then(function (drivers) {
            $scope.drivers = drivers;
        });

    statsData.getStats()
        .then(function (stats) {
            $scope.tripsTotal = stats.trips;
            $scope.upcomingTrips = stats.finishedTrips;
            $scope.usersCount = stats.users;
            $scope.driversCount = stats.drivers;
    });

});