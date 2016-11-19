var clientsApp = angular.module('clientsApp', ["sharedCode"]);

clientsApp.run(function($rootScope) {
    $rootScope.apiURL = "http://localhost:61314/api/";
});
