angular.module('mainApp', ['eventModule', 'searchTitlesModule'])
	.config([function () {
		//Config
	}])
	.run([function () {
		console.log('App is running');
	}])
	.factory('Titles', ['$http', function ($http) {
		return {
			get: function (token, skip, success) {
				if (!skip)
					skip = 0;
				$http.get('api/titles?token=' + token + '&skip=' + skip)
					.success(function (data) {
						success(data);
					})
			}
		}
	}]);