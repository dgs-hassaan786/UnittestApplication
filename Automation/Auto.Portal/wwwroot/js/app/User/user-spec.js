
describe('Users factory', function () {
    var Users;
    // The array of users our factory will provide us
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

    //The single user we expect to receive when calling findById('2')
    var singleUser = {
        id: '2',
        name: 'Bob',
        role: 'Developer',
        location: 'New York',
        twitter: 'billybob'
    };

    // Before each test load our api.users module
    beforeEach(angular.mock.module('my_app'));
    // Before each test set our injected Users factory (_Users_) to our local Users variable
    beforeEach(inject(function (_Users_) {
        Users = _Users_;
    }));
    // A simple test to verify the Users factory exists
    it('User factory should exist', function () {
        expect(Users).toBeDefined();
    });

    // A set of tests for our Users.all() method
    describe('.all()', function () {
        // A simple test to verify the method all exists
        it('should exist', function () {
            expect(Users.all).toBeDefined();
        });
        // A test to verify that calling all() returns the array of users we hard-coded above
        it('should return a hard-coded list of users', function () {
            expect(Users.all()).toEqual(userList);
        });
    });

    // A set of tests for our Users.findById() method
    describe('.findById()', function () {
        // A simple test to verify the method findById exists
        it('should exist', function () {
            expect(Users.findById).toBeDefined();
        });
        // A test to verify that calling findById() with an id, in this case '2', returns a single user
        it('should return one user object if it exists', function () {
            expect(Users.findById('2')).toEqual(singleUser);
        });
        it('should return undefined if the user cannot be found', function () {
            expect(Users.findById('ABC')).not.toBeDefined();
        });
    });


});


describe('Users Controller', function () {
    var $controller, UsersController, UsersFactory , scope;

    // Mock the list of users we expect to use in our controller
    var userList = [
      { id: '1', name: 'Jane', role: 'Designer', location: 'New York', twitter: 'gijane' },
      { id: '2', name: 'Bob', role: 'Developer', location: 'New York', twitter: 'billybob' },
      { id: '3', name: 'Jim', role: 'Developer', location: 'Chicago', twitter: 'jimbo' },
      { id: '4', name: 'Bill', role: 'Designer', location: 'LA', twitter: 'dabill' }
    ];


    // Before each test load our api.users module
    beforeEach(angular.mock.module('my_app'));

    // Inject the $controller service to create instances of the controller (UsersController) we want to test
    beforeEach(inject(function (_$controller_, _Users_, $rootScope) {
        $controller = _$controller_;
        UsersFactory = _Users_;

        // Spy and force the return value when UsersFactory.all() is called
        spyOn(UsersFactory, 'all').and.callFake(function () {
            return userList;
        });

        // Create a new scope that's a child of the $rootScope
        scope = $rootScope.$new();
        UsersController = $controller('UsersCtrl', { $scope: scope, Users: UsersFactory });
    }));

    // Verify our controller exists
    it('Users controller should be defined', function () {
        expect(UsersController).toBeDefined();
    });

    // Add a new test for our expected controller behavior
    it('should initialize with a call to Users.all()', function () {
        expect(UsersFactory.all).toHaveBeenCalled();
        expect(scope.users).toEqual(userList);
    });

    // Number Addition
    it("should double the numbers", function () {
        scope.doubleIt();
        expect(scope.x).toBe(6);
    });
});
describe('BAC User factory', function () {
    var BACUsersFactory, $q, $httpBackend;

    // Add Pokeapi endpoint
    var API = 'http://localhost:7256/user/';
    // Before each test load our api.users module
    beforeEach(angular.mock.module('my_app'));
    // Before each test set our injected Users factory (_Users_) to our local Users variable
    beforeEach(inject(function (_BACUsersFactory_, _$q_, _$httpBackend_) {
        BACUsersFactory = _BACUsersFactory_;
        $q = _$q_;
        $httpBackend = _$httpBackend_;
    }));

    // A simple test to verify the Users factory exists
    it('BAC User factory should be defined', function () {
        expect(BACUsersFactory).toBeDefined();
    });
   
});
