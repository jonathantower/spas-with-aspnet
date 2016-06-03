angular.module("app").controller('ctrlLogout', ['$http', '$location', '$rootScope', function ($http, $location, $rootScope) {
	$http({
		url: "/api/logout",
		method: "GET"
	}).success(function (data, status, headers, config) {
		$rootScope.authenticated = false;
		$location.path("/");
	}).error(function (data, status, headers, config) {
	});
}]);