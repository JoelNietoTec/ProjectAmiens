var positionsController = function ($scope, $http, crud) {

    $scope.getPositions = function () {
        $scope.items = {};
        crud.getItems($scope.apiURL + "Positions")
            .then(function (d) {
                $scope.items = d;
            });
    };

    $scope.addPosition = function () {
        var position = $scope.newPosition;
        crud.addItem($scope.apiURL + "Positions", position)
            .then(function (d) {
                $scope.newPosition = {};
                $scope.items.push(d);
            });
    };

    $scope.editPosition = function(item) {
        $scope.selectedItem = item;
        $scope.editedPosition = angular.copy($scope.selectedItem);
    };

    $scope.updatePosition = function() {
        if (angular.toJson($scope.editedPosition) === angular.toJson($scope.selectedItem)) {
            console.log("No Change");
        } else {
            var position = $scope.editedPosition;
            crud.updateItem($scope.apiURL + "Positions", position.Id, position)
            .then(function(d){
                console.log(position);
                $scope.getPositions();
            });
        };
    };

    $scope.getPositions();
};

positionsController.$inject = ['$scope', '$http', 'crudService'];