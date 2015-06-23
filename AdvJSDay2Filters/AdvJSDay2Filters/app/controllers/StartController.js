(function () {
    angular.module('FilterApp').controller('StartController', StartController);

    function StartController() {
        var vm = this;

        vm.message = "Start View";
        //vm.food = [
        //    { name: 'Milk', price: 2.33, dateCreated:new Date('12/31/1977') },
        //    { name: 'Marzipan', price: 99.88, dateCreated: new Date('1/8/1982') },
        //    { name: 'Mustard', price: 6.77, dateCreated: new Date('12/04/1922') },
        //    { name: 'Eggs', price: 3.44, dateCreated: new Date('12/31/1977') }
        //];        

        vm.fetch = function () {
            var all = [
                'Milk',
                'Marzipan',
                'Mustard',
                'Eggs'
            ];

            var search = vm.search.toLowerCase();

            vm.food = all.filter(function (item) {
                return item.toLowerCase().startsWith(search);
            });
        }
    }
})();