var clientsController = function ($scope, $http, $q, crud) {
    var entity = "Clients";

    $scope.getClients = function () {
        $scope.items = {};
        crud.getItems($scope.apiURL + entity)
            .then(function (d) {
                $scope.items = d;
            });
    };

    $scope.addClient = function () {
        var client = $scope.newClient;
        crud.addItem($scope.apiURL + entity, client)
            .then(function (d) {
                console.log(d);
                $scope.newClient = {}
                $scope.items.push(d);
            });
    };

    $scope.getClients();
};

clientsController.$inject = ['$scope', '$http', '$q', 'crudService'];