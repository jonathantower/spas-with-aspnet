var app = angular.module("app", ["ngRoute"]);
app.config(['$routeProvider', function ($routeProvider) {
	$routeProvider.
      when('/orders', {
      	templateUrl: 'HtmlViews/Orders',
      	controller: 'ctrlOrders'
      }).
	  when('/login', {
	  	templateUrl: 'HtmlViews/Login',
	  	controller: 'ctrlLogin'
	  }).
	  when('/logout', {
	  	templateUrl: 'HtmlViews/Logout',
	  	controller: 'ctrlLogout'
	  }).
	  when('/home', {
	  	templateUrl: 'HtmlViews/Home',
	  }).
	  when('/', {
	  	templateUrl: 'HtmlViews/Home',
	  }).
      otherwise({
      	redirectTo: '/'
      });
}]).run(['$rootScope', function ($rootScope) {
	var config = window.config;
	$rootScope.allowLogin = config.allowLogin;
}]);