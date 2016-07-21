angular.module('eventModule', [])
	.config([function () {
		//Config
	}])
	.run([function () {
		console.log('Event Module Running');
	}])
	.controller('EventCtrl', ['$scope', function ($scope) {
		$scope.title = "Search the DB!";
	}]);
