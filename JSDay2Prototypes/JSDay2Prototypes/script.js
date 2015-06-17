'use strict';

//function Product(name, price) {
//    this._name = name;
//    this._price = price;
//}

//Product.prototype = {
//    calculateTax: function () {
//        return this._price * 0.08;
//    }
//};

//var product1 = new Product("Milk", 2.33);
//var product2 = new Product("Cheese", 4.33);


function Product(name, price) {
    this._name = name;
    this._price = price;

    function _calculateTaxPrice(price) {
        return price * 0.0825;
    }

    this.calculateTotalPrice = function() {
        return this._price + _calculateTaxPrice(this._price);
    }
}

//Product.prototype = (function () {
//    function _calculateTaxPrice(price) {
//        return price * 0.0825;
//    }

//    function _calculateTotalPrice() {
//        return this._price + _calculateTaxPrice(this._price);
//    }

//    return {
//        calculateTotalPrice: _calculateTotalPrice
//    };
//})();


var nicksCar = new Product("Honda", 24000);
var coke = new Product("Coke", 1.99);

console.log(nicksCar.calculateTotalPrice());
//console.log(nicksCar._calculateTaxPrice(24000));
console.log(coke.calculateTotalPrice());