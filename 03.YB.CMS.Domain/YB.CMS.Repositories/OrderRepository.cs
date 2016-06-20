using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Infrastructure;
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
                    ShopName=item.ShopName
                }).ToList();
                grid.total = total;
                return grid;
            });
        }
    }
}
