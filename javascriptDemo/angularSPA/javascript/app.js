var myModule = angular.module("myModule", ['ngAnimate', 'ui.router']);

myModule.config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
    $stateProvider.state("main", {
            url: "/main",
            templateUrl: "register/main.html",
            controller: "mainController"
        })
        .state("main.documents", {
            url: "/documents",
            templateUrl: "register/documents.html"
        })
        .state("main.about", {
            url: "/about",
            template: "<p><h1>this About!</h1></p><p><h1>this Function Used Template!</h1></p>",
        })
        .state("main.multiview", {
            url: "/multiview",
            views: {
                "": {
                    template: "<p><h1>this multiview!</h1></p><p><h1>this Function Used Multivews!</h1></p>",
                },
                "customerview": {
                    template: "<h3>this Customer Views</h3>"
                }
            }
        })
        .state("main.statebind", {
            url: "/statebind",
            templateUrl: "register/statebind.html"
        });

    $urlRouterProvider.otherwise('/form/required');
}]);

myModule.controller("mainController", ["$scope", function($scope) {
    $scope.data = { document: "this function Used State Data!" };
    $scope.submit = function() {
        alert("Cool, you have registered!");
    };
}]);