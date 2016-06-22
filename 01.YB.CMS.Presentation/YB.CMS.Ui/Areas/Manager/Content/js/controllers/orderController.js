var app = angular.module('CmsApp', ['ngTable','ngTableToCsv']).
    controller('orderCtrl', function ($scope, ngTableParams, orderService) {
        var vm = $scope.vm = {
            orderid: "",
            stime: new Date(new Date().getTime()).format('yyyy-mm-dd'),
            etime: new Date(new Date().getTime()).format('yyyy-mm-dd'),
            pagesize: 20,
            total: 0,
            sortorder: "",
            sortcolumn: "",
            distributor: []
        };
        orderService.getDistributor().then(function (data) {
            $scope.selectParams = data;
        });
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
                params.distributor = vm.distributor.Id;
                orderService.orderList($defer, params);
                vm.total = params.total;
            }
        });
        $scope.search = function () {
            if (vm.orderid === "" && vm.stime === "" && vm.etime === "" && vm.distributor.Id == "") {
                return;
            }
            $scope.tableParams.page(1);
            $scope.tableParams.reload();
        };
        $scope.clear = function () {
            vm.etime = new Date(new Date().getTime()).format('yyyy-mm-dd');
            vm.stime = new Date(new Date().getTime() - 6 * 24 * 60 * 60 * 1000).format('yyyy-mm-dd');
            vm.orderid = "";
            vm.distributor = [];
            $scope.tableParams.page(1);
            $scope.tableParams.reload();
        };
    }).
    service("orderService", function ($http, $q) {
        var service = {
            orderList: function ($defer, params) {
                $http.get("/Manager/Order/OrderList", {
                    params: {
                        page: params.page() - 1,
                        pagesize: params.pagesize,
                        orderid: params.orderid,
                        stime: params.stime,
                        etime: params.etime,
                        sortorder: params.sortorder,
                        sortcolumn: params.sortcolumn,
                        distributor: params.distributor
                    }
                }).success(function (resp) {
                    params.total(resp.total);
                    $defer.resolve(resp.data);
                }).error(function () {
                    $defer.reject("获取数据异常");
                });
            },
            getDistributor: function () {
                var defer = $q.defer();
                $http.get("/Manager/System/getDistributor", {
                })
                    .success(function (resp) {
                        defer.resolve(resp);
                    }).error(function () {
                        defer.reject("获取数据异常");
                    });
                return defer.promise;
            }
        }
        return service;
    }).filter("jsonDate", ['$filter', function ($filter) {
        return function (input, format) {
            var timestamp = Number(input.replace(/\/Date\((\d+)\)\//, "$1"));
            return $filter("date")(timestamp, format);
        };
    }]).filter("order_paltform", ['$sce', function ($sce) {
        return function (input, orderid) {
            var text = input;
            if (input === '移动端')
                text = "<i class=\"fa fa-android\"></i>";
            else if (input === 'PC')
                text = "<i class=\"fa fa-apple\"></i>";
            else
                text = "<i class=\"fa fa-level-down\"></i>";
            return $sce.trustAsHtml(text + " " + orderid);
        }
    }]);