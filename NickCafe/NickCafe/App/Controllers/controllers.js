(function () {
    angular.module('CafeApp').controller('WelcomeController', Welcome)
    .controller('MenuController', Menu).controller('AddController', Add);

    function Welcome()
    {
        var vm = this;

        vm.message = 'Welcome Page';
    }

    function Menu() {
        var vm = this;

        vm.message = 'Menu Page';


    }

    function Add() {
        var vm = this;

        vm.message = 'Add Page';
    }




})();