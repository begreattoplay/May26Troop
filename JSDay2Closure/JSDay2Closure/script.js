'use strict';

var buttons = document.getElementsByTagName('button');

addClickHandlers(buttons);

function addClickHandlers(buttons) {
    for (var i = 0; i < buttons.length; i++) {
        addClickHandler(buttons[i], i);
    }
}

function addClickHandler(button, index) {
    button.addEventListener('click', function () {
        alert('You clicked button ' + button.innerHTML);
    })
}

function getFunction(message) {

    //inner function
    return function () {
        console.log(`He says "${message}"`);
    }
}

var func = getFunction("Hello Mike");
func();
func();

var func2 = getFunction("Nick is Hungry!");
func2();
func2();