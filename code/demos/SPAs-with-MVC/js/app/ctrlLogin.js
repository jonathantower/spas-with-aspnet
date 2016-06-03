angular.module("app").controller('ctrlLogin', ['$scope', '$http', '$location', '$rootScope', function ($scope, $http, $location, $rootScope) {
	$scope.form = {
		username: "",
		password: ""
	};

	$scope.login = function () {
		$http({
			url: "/api/login",
			method: "POST",
			data: $scope.form
		}).success(function (data, status, headers, config) {
			$rootScope.authenticated = true;
			$location.path("/");
		}).error(function (data, status, headers, config) {
			$scope.validation = data;
		});
	}
}]);