var crudService = function ($http) {
    var funcs = {};

    funcs.getItems = function (apiURL) {
        var promise = $http.get(apiURL)
            .then(function (response) {
                return response.data;
            }, function (response) {
                console.log(response);
            });
        return promise;
    };

    funcs.getItem = function (apiURL, id) {
        if (apiURL.slice(-1) != "/")
            apiURL = apiURL + "/";

        var promise = $http.get(apiURL + id)
            .then(function (response) {
                return response.data;
            }, function (response) {
                console.log(response);
            });
        return promise;
    };

    funcs.addItem = function (apiURL, element) {
        var promise =
            $http.post(
                apiURL,
                anngular.toJson(element),
                {
                    header: {
                        'Content-Type': 'application/json'
                    }
                })
                .then(function (response) {
                    return response.data;
                }, function (response) {
                    console.log(response);
                });
        return promise;
    }

    return funcs;
}

crudService.$inject = ['$http'];