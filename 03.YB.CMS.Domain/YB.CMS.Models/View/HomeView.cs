using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.View
{
    public class HomeView
    {
        /// <summary>
        /// 销售额
        /// </summary>
        public DecimalTrend SaleAmount { get; set; }
        /// <summary>
        /// 下单数
        /// </summary>
        public LongTrend OrderNumber { get; set; }
        /// <summary>
        /// 店铺数
        /// </summary>
        public LongTrend ShopNumber { get; set; }
        /// <summary>
        /// 用户数
        /// </summary>
        public LongTrend UserNumber { get; set; }
    }
    /// <summary>
    /// 金额趋势(昨天、今天)
    /// </summary>
    public class DecimalTrend
    {
        public DecimalTrend()
        {
            this.TodayAmount = 0;
            this.YesterdayAmount = 0;
        }
        public decimal? TodayAmount { get; set; }
        public decimal? YesterdayAmount { get; set; }
    }
    /// <summary>
    /// 数量趋势(昨天、今天)
    /// </summary>
    public class LongTrend
    {
        public LongTrend()
        {
            this.TodayNumber = 0;
            this.YesterdayNumber = 0;
        }
        public long? TodayNumber { get; set; }
        public long? YesterdayNumber { get; set; }
    }
}
