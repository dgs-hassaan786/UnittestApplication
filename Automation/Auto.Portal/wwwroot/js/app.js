(function () {
    'use strict';

    var app = angular.module('my_app', []);

    app.controller('UserController', function ($scope) {

        debugger

        $scope.sayHello = function () {
            debugger
            return 'Hello World';
        }

    });

})();