using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Models;
using YB.CMS.Models.Model;
using YB.CMS.Models.Query;
using YB.CMS.Models.View;
namespace YB.CMS.IRepositories
{
    public interface IOrderRepository : IRepository<Himall_Orders>
    {
        AngularTable<PlatOrderView> GetOrderList(OrderQuery query);
    }
}
