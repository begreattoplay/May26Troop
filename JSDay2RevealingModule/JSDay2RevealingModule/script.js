'use strict';

var module = (function () {
    //private methods
    function _calculatePrice(price) {
        return price + _calculateTax(price);
    }

    function _calculateTax(price) {
        return price * .08;
    }

    //exports
    return {
        calculatePrice: _calculatePrice
    }
})();

console.log(module.calculatePrice(45.99));
var tax = module._calculateTax(5.00);