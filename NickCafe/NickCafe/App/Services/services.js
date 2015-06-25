(function () {
    angular.module('CafeApp').factory('menuService', menuService);

    function menuService($http, $q) {
        var products = [];
        var initialDeferred = $q.defer();
        var service = {};

        preloadProducts();

        service.getProducts = getProducts;
        service.addProduct = addProduct;

        function preloadProducts() {
            $http.get('/api/menu')
                .success(function (data) {
                    console.log(data);

                    data.forEach(function (product) {
                        products.push(product);
                    })

                    initialDeferred.resolve(products);
                })
                .error(function () {
                    initialDeferred.reject();
                });
        }

        function getProducts() {
            return initialDeferred.promise;
        };

        function addProduct(product) {
            var deferred = $q.defer();
            $http.post('/api/menu', product)
                .success(function (data) {
                    if (data) {
                        products.push(product);
                    }

                    deferred.resolve();
                })
                .error(function () {
                    deferred.reject();
                });

            return deferred.promise;
        };

        return service;
    }
})();