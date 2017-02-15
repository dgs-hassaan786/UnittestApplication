(function () {
    'use strict';

    angular.module('my_app', [])
    .controller('UserCtrl', ['$scope', function ($scope) {

    }])
    .factory('Users', function () {
        var Users = {};
        var userList = [
            {
                id: '1',
                name: 'Jane',
                role: 'Designer',
                location: 'New York',
                twitter: 'gijane'
            },
            {
                id: '2',
                name: 'Bob',
                role: 'Developer',
                location: 'New York',
                twitter: 'billybob'
            },
            {
                id: '3',
                name: 'Jim',
                role: 'Developer',
                location: 'Chicago',
                twitter: 'jimbo'
            },
            {
                id: '4',
                name: 'Bill',
                role: 'Designer',
                location: 'LA',
                twitter: 'dabill'
            }
        ];
        // Defining all to make our test pass. It doesn't need to do anything yet.
        Users.all = function () {
            return userList;
        };
        Users.findById = function (id) {
            // Returning a single user object as our test expects it to
            return userList.find(function (user) {
                return user.id === id;
            });
        };
        return Users;
    });

})();