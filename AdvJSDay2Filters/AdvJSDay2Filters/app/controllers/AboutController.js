(function () {
    angular.module('FilterApp').controller('AboutController', AboutController);

    function AboutController() {
        var vm = this;

        vm.message = "About View";
    }
})();