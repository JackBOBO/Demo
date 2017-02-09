var myModule = angular.module("myModule", ['ngAnimate', 'ui.router']);

myModule.config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
    $stateProvider.state("main", {
            url: "/main",
            templateUrl: "register/main.html",
            controller: "mainController",
        })
        .state("main.documents", {
            //#/main/documents/:111/:222
            //url: "/documents/:p1/:p2",
            //#/main/documents?p1=11111&p2=2222
            //url: "/documents?p1&p2",
            url: "/document/{p1}{p2}",
            templateUrl: "register/documents.html",
            controller: function($stateParams) {
                debugger;
                this.message = "this Function Used templateUrl!";
            },
            controllerAs: 'centerData',
            onEnter: function() {
                console.log('in main.documents view');
            },
            onExit: function() {
                console.log('out main.documents view');
            }
        })
        .state("main.about", {
            url: "/about",
            template: "<p><h1>{{name}}</h1></p><p><h1>{{description}}</h1></p>",
            controller: function($scope) {
                $scope.name = "this About!";
                $scope.description = "this Function Used Template!";
            }
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
        })
        .state("main.resolveexample", {
            url: "resolveexample",
            templateProvider: function() {
                return "<p><h1>this Resolve!</h1></p><p><h3>{{simple}}</h3></p>";
            },
            resolve: {
                simpleObj: function() {
                        return { value: "ths Function Used Resolve!" };
                    }
                    // promiseObj: function($http) {
                    //     return $http({ methods: 'GET', url: '/someUrl' });
                    // },
                    // promiseObj2: function($http) {
                    //     return $http({ method: 'GET', url: '/someUrl' })
                    //         .then(function(data) {
                    //             return doSomeStuffFirst(data);
                    //         });
                    // },
                    // translations: "translations",
                    // translations2: function(translations, $stateParams) {
                    //     return translations.getLang($stateParams.lang);
                    // },
                    // greeting: function($q, $timeout) {
                    //     var deferred = $q.defer();
                    //     $timeout(function() {
                    //         deferred.resolve('Hello!');
                    //     }, 1000);

                //     return deferred.promise;
                // },
            },
            controller: function($scope, simpleObj) {
                //, promiseObj, promiseObj2, translations, translations2, greeting
                $scope.simple = simpleObj.value;

                // You can be sure that promiseObj is ready to use!
                // $scope.items = promiseObj.data.items;
                // $scope.items = promiseObj2.items;

                // $scope.title = translations.getLang("english").title;
                // $scope.title = translations2.title;

                // $scope.greeting = greeting;
            }
        })
        .state("main.statedata", {
            url: "/statedata",
            templateUrl: "register/statedata.html",
            data: {
                name: "this State Data!",
                description: "this Function Used StateData!"
            }
        })
        .state("errorMain", {
            url: "/errorMain",
            template: "<p><h1>not find view!</h1> </p>"
        });


    //$urlRouterProvider.when('', '/inbox');
    $urlRouterProvider.otherwise('/errorMain');
}]);

myModule.controller("mainController", ["$scope", function($scope) {
    $scope.data = { document: "this function Used State Data!" };
    $scope.submit = function() {
        alert("Cool, you have registered!");
    };

    $scope.$on('$viewContentLoading',
        function(event, viewConfig) {
            console.log('$viewContentLoading');
        });

    $scope.$on('$viewContentLoaded',
        function(event, viewConfig) {
            console.log('$viewContentLoaded');
        });

    $scope.$on('$stateChangeStart', function(event, toState) {
        if (toState && toState.data && toState.data.name && toState.data.description) {
            var message = toState.data.name + " " + toState.data.description;
            console.log(message);
        }
    })
}]);