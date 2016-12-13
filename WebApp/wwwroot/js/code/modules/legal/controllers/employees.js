var employeesController = function ($scope, $http, $q, crud) {

    $scope.getEmployees = function () {
        $scope.items = {};
        crud.getItems($scope.apiURL + "Employees")
            .then(function (d) {
                $scope.items = d;
            });
    };

    $scope.initObjects = function () {
        $q.all([
            crud.getItems($scope.apiURL + "Positions").then(function (d) { $scope.positions = d; })
        ]);
    };

    $scope.initObjects();
    $scope.getEmployees();

};

employeesController.$inject = ['$scope', '$http', '$q', 'crudService'];