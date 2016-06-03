angular.module("app").controller('ctrlOrders', ['$scope', '$http', function ($scope, $http) {
	$scope.orders = [];

	$http({
		url: "/api/orders",
		method: "GET"
	}).success(function (data, status, headers, config) {
		$scope.orders = data;
	}).error(function (data, status, headers, config) {
		$scope.validation = data;
	});
}]);