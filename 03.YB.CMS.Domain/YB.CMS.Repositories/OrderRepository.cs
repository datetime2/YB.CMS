using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.IRepositories;
using YB.CMS.Models.Model;
using YB.CMS.Models.Query;
using YB.CMS.Models.View;
using Dapper;
using DapperEx;
using YB.CMS.Models;
using YB.CMS.Utility;
namespace YB.CMS.Repositories
{
    public class OrderRepository : Repository<Himall_Orders>, IOrderRepository
    {
        public AngularTable<OrderView> GetOrderList(OrderQuery query)
        {
            return QueryDb<AngularTable<OrderView>>((context) =>
            {
                AngularTable<OrderView> grid = new AngularTable<OrderView>();
                var d = SqlQuery<Himall_Orders>.Builder(context);
                if (query.OrderId.HasValue)
                    d.AndWhere(m => m.Id, OperationMethod.Equal, query.OrderId.Value);
                if (query.OrderDateS.HasValue && query.OrderDateE.HasValue)
                    d.AndWhere(m => m.OrderDate, OperationMethod.Greater, query.OrderDateS.Value)
                     .AndWhere(m => m.OrderDate, OperationMethod.LessOrEqual, query.OrderDateE.Value);
                if (query.DistributorId.HasValue)
                    d.AndWhere(m => m.DistributorID, OperationMethod.Equal, query.DistributorId.Value);
                switch (query.SortColumn)
                {
                    case "Id":
                        d.OrderBy(m => m.Id, query.IsDesc);
                        break;
                    case "OrderDate":
                        d.OrderBy(m => m.OrderDate, query.IsDesc);
                        break;
                    case "PushCustomsTax":
                        d.OrderBy(m => m.PushCustomsTax, query.IsDesc);
                        break;
                    case "OrderStatus":
                        d.OrderBy(m => m.OrderStatus, query.IsDesc);
                        break;
                    case "UserName":
                        d.OrderBy(m => m.UserName, query.IsDesc);
                        break;
                    case "IsPush":
                        d.OrderBy(m => m.IsPush, query.IsDesc);
                        break;
                    default:
                        d.OrderBy(m => m.OrderDate, true);
                        break;
                }
                var result = context.Page<Himall_Orders>(query.Page.Value, query.PageSize.Value, out total, d);
                grid.data = result.Select(item => new OrderView
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    ShipTo = item.ShipTo,
                    OrderDate = item.OrderDate,
                    Freight = item.Freight,
                    PushCustomsTax = item.PushCustomsTax,
                    ProductTotalAmount = item.ProductTotalAmount,
                    OrderStatus = item.OrderStatus.ToDescription(),
                    ShopName = item.ShopName,
                    IsPush = item.IsPush == 1 ? "是" : "否",
                    IntegralDiscount = item.IntegralDiscount,
                    DiscountAmount = item.DiscountAmount
                }).ToList();
                grid.total = total;
                return grid;
            });
        }

        #region Private Method
       
        #endregion
    }
}
