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
	}])
	.directive('onKeyEnter', ['$parse', function ($parse) {
		return {
			restrict: 'A',
			link: function (scope, element, attrs) {
				element.bind('keydown keypress', function (event) {
					if (event.which === 13) {
						var attrValue = $parse(attrs.onKeyEnter);
						(typeof attrValue === 'function') ? attrValue(scope) : angular.noop();
						event.preventDefault();
					}
				});
				scope.$on('$destroy', function () {
					element.unbind('keydown keypress')
				})
			}
		};
	}]);