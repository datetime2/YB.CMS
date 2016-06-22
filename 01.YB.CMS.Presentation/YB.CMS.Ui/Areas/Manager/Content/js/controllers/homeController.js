var app = angular.module('CmsApp', []).controller('homeCtrl', function ($scope, homeService) {
    var vm = $scope.vm = {
        inbox: {}
    };
    homeService.getPlatHome().then(function (data) {
        vm.inbox = data;
    });
}).service('homeService', function ($http, $q) {
    var service = {
        getPlatHome: function () {
            var defer = $q.defer();
            $http.get("/Manager/Home/PlatHome", {
            })
                .success(function (resp) {
                    defer.resolve(resp);
                }).error(function () {
                    defer.reject("获取数据异常");
                });
            return defer.promise;
        }
    };
    return service;
}).filter("trend_conversion", ['$sce', function ($sce) {
    return function (input) {
        var text = input;
        if (input === '0.00')
            text = "<i class=\"fa fa-bolt\"></i>";
        else if (input > 0)
            text = (parseFloat(input) * 100).toFixed(2) + "%" + "<i class=\"fa fa-level-up\"></i>";
        else
            text = (parseFloat(0 - input) * 100).toFixed(2) + "%" + "<i class=\"fa fa-level-down\"></i>";
        return $sce.trustAsHtml(text);
    }
}]);