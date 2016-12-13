var clientsController = function ($scope, $http, $q, crud) {

    $scope.initForm = function () {
        $q.all([
            crud.getItems($scope.apiURL + "Countries").then(function (d) { $scope.countries = d; })
        ]);
    };

    $scope.initForm();

};

clientsController.$inject = ['$scope', '$http', '$q', 'crudService'];