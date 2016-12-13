var customersApp = angular.module('customersApp', []);

customersApp.run(function ($rootScope) {
    $rootScope.apiURL = "http://localhost:61314/api/";
});

customersApp.controller('clientsController', clientsController);