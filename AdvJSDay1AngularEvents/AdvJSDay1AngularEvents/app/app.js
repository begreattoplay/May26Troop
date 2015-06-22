(function () {
    angular.module('MyApp', []).controller("FavoriteController", function () {
        //default
        //this.color = "green"

        //change color
        this.pickColor = function (color) {
            this.color = color;
        }
    });
})();