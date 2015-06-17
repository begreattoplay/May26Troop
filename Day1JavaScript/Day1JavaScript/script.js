"use strict";

//var input = prompt("Enter a number");

//if (!input || isNaN(+input))
//    alert("Invalid Input");
//else
//    alert(+input * 100);

//function calculateTax(price, taxRate) {   
//    taxRate = taxRate === 0 ? taxRate : taxRate > 0 ? taxRate : 0.08;
//    return price + (price * taxRate);
//}

//var result = calculateTax(20);
//console.assert(result === 21.6);

//result = calculateTax(20, .05);
//console.assert(result === 21);

//result = calculateTax(20, 0);
//console.assert(result === 20);



//var colors = ['red', 'green', 'blue'];

//for (var color of colors) {
//    console.log(color);
//}

//var personObj = {
//    firstName: 'Nick',
//    lastName: 'Brittain',
//    favColor: 'Blue',
//    favNumber: 6
//};

//for (var propName in personObj) {
//    console.log(propName);
//    console.log(personObj[propName]);
//};

//function addIntegers(num1, num2) {
//    for (var arg in arguments) {
//        var num = arguments[arg];
//        if (num === undefined || num === null || typeof(num) == "string")
//            throw new Error("Argument " + arg + " has no value or is invalid");

//        if (isNaN(num) || num % 1 !== 0)
//            throw new Error(num + " is not an integer");
//    }

//    return num1 + num2;
//}

//var result = addIntegers("1", 2);
//result = addIntegers("apple");
//result = addIntegers(3.4, 1);

//console.log(result);


//var myObject = {};
//for (var i = 0; i < 100; i++) {
//    myObject['prop' + i] = 'My value is ' + i;
//}
//console.log(myObject.prop15);


var product = {
    _price: 0,
    //Set for Price
    set price(value) {
        if (value < 0) {
            throw Error('price cannot be less than 0.');
        }
        this._price = value;
    },
    //Get for Price
    get price() {
        return this._price;
    }
};

product.price = -300.00;
console.log(product.price);