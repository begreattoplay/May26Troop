(function () {

    angular.module('CafeApp', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when(
            '/',
            {
                templateUrl: '/App/Views/welcome.html',
                controller: 'WelcomeController',
                controllerAs: 'vm'
            })
        .when(
        '/menu',
        {
            templateUrl: '/App/Views/menu.html',
            controller: 'MenuController',
            controllerAs: 'vm'
        })
        .when(
        '/add',
        {
            templateUrl: '/App/Views/add.html',
            controller: 'AddController',
            controllerAs: 'vm'
        }).otherwise({
            redirectTo: '/'
        });

    }

})();