﻿angular.module('searchTitlesModule', [])
	.config([function () {
		//Config
	}])
	.run([function () {
		console.log('Event Module Running');
	}])

	.controller('SearchTitlesCtrl', ['$scope', 'Titles', function ($scope, Titles) {
		this.title = "Search For Movies!";
		this.searchString = "";

		this.items = [];
		this.loadLimit = 0;

		this.newSearch = function () {
			var scope = this;
			var success = function (data) {
				console.log(data);
				scope.items = data.Items;
				scope.loadLimit = data.TotalCount;
			};
			var failure = function () { };
			Titles.get(scope.searchString, 0, success, failure);
		};

		this.loadMore = function () {
			if (loadLimt > item.length) {
				var scope = this;
				var success = function (data) {
					console.log(data);
					scope.items.push(data.Items);

				};
				Titles.get(scope.searchString, items.length, success);
			}
		}
	}]);
