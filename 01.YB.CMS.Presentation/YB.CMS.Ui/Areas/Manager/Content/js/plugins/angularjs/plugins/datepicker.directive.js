app.directive('datetimepicker', function () {
	return {
		restrict: 'A',
		link: function (scope, element, attr) {
			var conf = {
				lang: 'zh'
			};
			conf.format = attr.format || 'Y-m-d';
			conf.timepicker = false;
			conf.maxDate = new Date();
			$(element).datetimepicker(conf);
		}
	};
});