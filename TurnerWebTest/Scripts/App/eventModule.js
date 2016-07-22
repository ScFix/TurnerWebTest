angular.module('eventModule', [])
	.config([function () {
		//Config
	}])
	.run([function () {
		console.log('Event Module Running');
	}])
	.controller('EventCtrl', ['$scope', function ($scope) {
		this.title = "Titles with Turner";
	}]);
