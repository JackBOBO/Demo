var contactsModule = angular.module("contactsModule", ['ngAnimate', 'ui.router']);

contactsModule.config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
    $stateProvider.state('contacts', {
            abstract: true,
            url: '/contacts',
            templateUrl: 'contacts/contacts.html',
            controller: function($scope) {
                $scope.contacts = [{ id: 0, name: "Alice" }, { id: 1, name: "Bob" }];
            }
        })
        .state('contacts.list', {
            url: '/list',
            templateUrl: 'contacts/contacts.list.html'
        })
        .state('contacts.detail', {
            url: '/:id',
            templateUrl: 'contacts/contacts.detail.html',
            controller: function($scope, $stateParams) {
                $scope.person = $scope.contacts[$stateParams.id];
            }
        })

    //$urlRouterProvider.otherwise('/errorMain');
}]);

contactsModule.controller("contactsController", ["$scope", function($scope) {
    // $scope.data = { document: "this function Used State Data!" };
    // $scope.submit = function() {
    //     alert("Cool, you have registered!");
    // };
}]);