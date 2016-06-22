var app = angular.module('CmsApp', ['angular-flot']).controller('homeCtrl', function ($scope, homeService) {
    var vm = $scope.vm = {
        SaleAmount: {},
        OrderNumber: {},
        OrderTotalNumber:{},
        ShopNumber: {},
        UserNumber: {}
    };
    homeService.getPlatHome().then(function (data) {
        vm.SaleAmount = data.SaleAmount;
        vm.OrderNumber = data.OrderNumber;
        vm.OrderTotalNumber = data.OrderTotalNumber;
        vm.ShopNumber = data.ShopNumber;
        vm.UserNumber = data.UserNumber;
        $scope.dataset = [{
            label: "订单数",
            data: data.OrderLines,
            color: "#1ab394",
            bars: {
                show: true,
                align: "center",
                barWidth: 24 * 60 * 60 * 600,
                lineWidth: 0
            }
        }, {
            label: "付款数",
            data: data.OrderPayLines,
            yaxis: 2,
            color: "#464f88",
            lines: {
                lineWidth: 1,
                show: true,
                fill: true,
                fillColor: {
                    colors: [{
                        opacity: 0.2
                    },
                    {
                        opacity: 0.2
                    }]
                }
            },
            splines: {
                show: false,
                tension: 0.6,
                lineWidth: 0,
                fill: 0.1
            },
        }];
        $scope.options = {
            xaxis: {
                mode: "time",
                tickSize: [1, "day"],
                tickLength: 0,
                axisLabel: "Date",
                timeformat: "%y-%m-%d",
                axisLabelUseCanvas: true,
                axisLabelFontSizePixels: 12,
                axisLabelFontFamily: "Arial",
                axisLabelPadding: 10,
                color: "#838383"
            },
            yaxes: [{
                position: "left",
                color: "#838383",
                axisLabelUseCanvas: true,
                axisLabelFontSizePixels: 12,
                axisLabelFontFamily: "Arial",
                axisLabelPadding: 3
            },
            {
                position: "right",
                clolor: "#838383",
                axisLabelUseCanvas: true,
                axisLabelFontSizePixels: 12,
                axisLabelFontFamily: " Arial",
                axisLabelPadding: 67
            }],
            legend: {
                noColumns: 1,
                labelBoxBorderColor: "#000000",
                position: "nw"
            },
            grid: {
                hoverable: false,
                borderWidth: 0,
                color: "#838383"
            }
        };
    });
}).service('homeService', function ($http, $q) {
    var service = {
        getPlatHome: function () {
            var defer = $q.defer();
            $http.get("/Manager/Home/PlatHome", {
            }).success(function (resp) {
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