(function () {
    angular.module('CafeApp').factory('menuService', menuService);

    function menuService() {
        var products = [{
            name: 'banana',
            productPrice: 1.99,
            productDescription: 'A breakfast food high in potassium',
            isBreakfast: true

        }];

        var getProducts = function () {
            return products;
        };

        var addProduct = function (product) {
            products.push(product);
        };

        return {
            getProducts: getProducts,
            addProduct: addProduct
        };
    }
})();