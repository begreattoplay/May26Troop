(function () {
    angular.module('CafeApp').controller('WelcomeController', Welcome)
    .controller('MenuController', Menu).controller('AddController', Add);

    function Welcome()
    {
        var vm = this;

        vm.message = 'Welcome Page';
    }

    function Menu(menuService) {
        var vm = this;

        vm.message = 'Menu Page';

        menuService.getProducts().then(function (products) {
            vm.menuItems = products;
        }, function () {

        });
    }

    function Add(menuService, $location) {
        var vm = this;

        vm.addItem = function () {
            var product = {
                name: vm.name,
                productPrice: vm.price,
                productDescription: vm.description,
                isBreakfast: vm.isBreakfast ? vm.isBreakfast : false
            };

            menuService.addProduct(product).then(redirectToMenu, displayError);
        };

        function redirectToMenu() {
            $location.path('/menu');
        }

        function displayError() {

        }
    }




})();