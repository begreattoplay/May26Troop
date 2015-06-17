'use strict';

//var counter = {
//    _count: 0,
//    addCount: function () {
//        this._count++;
//        console.log(this, this._count);
//    }
//};


//window.setInterval(counter.addCount.bind(counter), 1000);
//counter.addCount(); // writes 1
//counter.addCount(); // writes 2
//counter.addCount(); // writes 3


var thingA = {
    toString: function () {
        return 'thingA';
    },
    _count: 0
};

var thingB = {
    toString: function () {
        return 'thingB';
    },
    _count: 0
};

var addOne = function () {
    this._count++;
    console.log(`${this} has the count ${this._count}`);
};

addOne.call(thingA);
addOne.call(thingB);
addOne.call(thingB);

function addAll() {
    var result = 0;
    //arguments.forEach(function (value) {
    //    result += value;
    //});
    Array.prototype.forEach.call(arguments, function (value) {
        result += value;
    });
    return result;
};

var sum = addAll(2,5,10,19,4);
console.log(sum);