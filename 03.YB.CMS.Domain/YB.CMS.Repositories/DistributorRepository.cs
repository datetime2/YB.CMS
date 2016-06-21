using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.IRepositories;
using YB.CMS.Models.Model;
using YB.CMS.Models.View;
using DapperEx;
using Dapper;
namespace YB.CMS.Repositories
{
    public class DistributorRepository : Repository<Himall_Distributor>, IDistributorRepository
    {
        public List<SelectView> DropDistributor()
        {
            return QueryDb<List<SelectView>>((context) =>
            {
                var d = SqlQuery<Himall_Distributor>.Builder(context).AndWhere(s => s.IsDelete, OperationMethod.Equal, 0);
                return context.Query<Himall_Distributor>(d).Select(item => new SelectView
                {
                    Id = item.Id,
                    Name = item.Name
                }).ToList();
            });
        }
    }
}
