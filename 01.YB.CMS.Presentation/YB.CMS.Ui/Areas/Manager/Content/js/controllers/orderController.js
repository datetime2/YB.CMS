var app = angular.module('CmsApp', ['ngTable']).
    controller('orderCtrl', function ($scope, ngTableParams, orderService) {
        var vm = $scope.vm = {
            orderid: "",
            stime: "",//new Date(new Date().getTime() - 1 * 24 * 60 * 60 * 1000).format('yyyy-mm-dd'),
            etime: "",//new Date(new Date().getTime() - 1 * 24 * 60 * 60 * 1000).format('yyyy-mm-dd'),
            pagesize: 20,
            total: 0,
            sortorder: "",
            sortcolumn: ""
        };
        $scope.tableParams = new ngTableParams(
        {
            page: 1,
            count: vm.pagesize
        },
        {
            counts: [],
            total: vm.total,
            getData: function ($defer, params) {
                for (var i in params.sorting()) {
                    vm.sortcolumn = i;
                    vm.sortorder = params.sorting()[i];
                }
                params.pagesize = vm.pagesize;
                params.orderid = vm.orderid;
                params.stime = vm.stime;
                params.etime = vm.etime;
                params.sortcolumn = vm.sortcolumn;
                params.sortorder = vm.sortorder;
                orderService.orderList($defer, params);
                vm.total = params.total;
            }
        });
        $scope.search = function () {
            if (vm.orderid === "" && vm.stime === "" && vm.etime === "") {
                return;
            }
            $scope.tableParams.page(1);
            $scope.tableParams.reload();
        };
        $scope.clear = function () {
            vm.etime = new Date(new Date().getTime()).format('yyyy-mm-dd');
            vm.stime = new Date(new Date().getTime() - 6 * 24 * 60 * 60 * 1000).format('yyyy-mm-dd');
            vm.orderid = "";
            $scope.tableParams.page(1);
            $scope.tableParams.reload();
        };
    }).
    service("orderService", function ($http) {
        var service = {
            orderList: function ($defer, params) {
                $http.get("/Manager/Order/OrderList", {
                    params: {
                        page: params.page()-1,
                        pagesize: params.pagesize,
                        orderid: params.orderid,
                        stime: params.stime,
                        etime: params.etime,
                        sortorder: params.sortorder,
                        sortcolumn: params.sortcolumn
                    }
                })
                    .success(function (resp) {
                        params.total(resp.total);
                        $defer.resolve(resp.data);
                    }).error(function () {
                        $defer.reject("获取数据异常");
                    });
            }
        }
        return service;
    }).filter("click_rate_output", function () {
        return function (input) {
            var out = input;
            if (input === '0.00')
                out = "-";
            else if (input > 0)
                out = "↑ " + (parseFloat(input) * 100).toFixed(2) + " %";
            else
                out = "↓ " + ((0 - parseFloat(input)) * 100).toFixed(2) + " %";
            return out;
        }
    });