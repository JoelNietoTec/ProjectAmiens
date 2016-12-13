var legalApp = angular.module('legalApp', ["sharedCode"]);

legalApp.run(function ($rootScope) {
    $rootScope.apiURL = "http://localhost:61314/api/";
});

legalApp.controller('positionsController', positionsController);

legalApp.controller('employeesController', employeesController);