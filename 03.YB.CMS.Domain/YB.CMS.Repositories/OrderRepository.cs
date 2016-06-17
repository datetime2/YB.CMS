using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;
using YB.CMS.Infrastructure;
using YB.CMS.IRepositories;
using YB.CMS.Models.Model;

namespace YB.CMS.Repositories
{
    public class OrderRepository : Repository<Himall_Orders>, IOrderRepository
    {

    }
}
