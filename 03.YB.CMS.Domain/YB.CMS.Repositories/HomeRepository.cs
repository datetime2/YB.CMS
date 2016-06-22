using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Models.View;
using YB.CMS.IRepositories;
namespace YB.CMS.Repositories
{
    public class HomeRepository : Repository<PlatHomeView>, IHomeRepository
    {
        public PlatHomeView PlatHomeModel()
        {
            //return QueryDb<PlatHomeView>((context) =>
            //{
            var home = new PlatHomeView
            {
                OrderNumber = new LongTrend
                {
                    TodayNumber = 5263,
                    ContrastNumber = 2365
                },
                SaleAmount = new DecimalTrend
                {
                    TodayAmount = 1536523.15M,
                    ContrastAmount = 1202365.63M
                },
                ShopNumber = new LongTrend
                {
                    TodayNumber = 0,
                    ContrastNumber = 12
                },
                UserNumber = new LongTrend
                {
                    TodayNumber = 268,
                    ContrastNumber = 1658
                }
            };
            return home;
            //});
        }
    }
}
