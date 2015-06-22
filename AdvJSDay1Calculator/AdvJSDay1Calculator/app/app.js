(function () {
    angular.module('CalcApp', [])
        .controller('CalcController', CalcController);

    function CalcController() {
        this.add = function () {
            this.result = +this.num1 + +this.num2;
        }
    }
})();