(function () {
    angular.module('PetShopApp', []).controller('PetsController', function () {
        this.petsByCat = [
            {
                name: 'Dogs',
                animals: [
                    { id: 1, name: 'Rover', url: 'http://i0.wp.com/www.mrlancechung.com/wp-content/uploads/2015/03/mr-porter-remix-the-dog-copy1.jpg' },
                    { id: 2, name: 'Astro', url: 'http://vignette3.wikia.nocookie.net/hanna-barbera/images/3/36/Dogs-astro.png/revision/latest?cb=20110206031013' }
                ],
            },
            {
                name: 'Bunnies',
                animals: [
                    { id: 1, name: 'Bunnicula', url: 'https://todayspetpics.files.wordpress.com/2013/05/bunnicula.jpg' },
                    { id: 2, name: 'Peter Rabbit', url: 'http://orig01.deviantart.net/ae78/f/2009/327/5/8/peter_rabbit_by_kemuff.png' }
                ]
            },
            {
                name: 'Fish',
                animals: [
                    { id: 1, name: 'Gold Fish', url: 'https://todayspetpics.files.wordpress.com/2013/05/bunnicula.jpg' },
                    { id: 2, name: 'Arrowana', url: 'http://orig01.deviantart.net/ae78/f/2009/327/5/8/peter_rabbit_by_kemuff.png' }
                ]
            }
        ];
    });
})();