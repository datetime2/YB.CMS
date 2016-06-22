using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.View
{
    public class PlatHomeView
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
        /// 订单总数
        /// </summary>
        public LongTrend OrderTotalNumber { get; set; }
        /// <summary>
        /// 店铺数
        /// </summary>
        public LongTrend ShopNumber { get; set; }
        /// <summary>
        /// 用户数
        /// </summary>
        public LongTrend UserNumber { get; set; }
        /// <summary>
        /// 订单下单数
        /// </summary>
        public List<long[,]> OrderLines { get; set; }
        /// <summary>
        /// 订单付款数
        /// </summary>
        public List<long[,]> OrderPayLines { get; set; }
    }
    /// <summary>
    /// 金额趋势(今天,对比金额)
    /// </summary>
    public class DecimalTrend
    {
        public DecimalTrend()
        {
            this.TodayAmount = 0;
            this.ContrastAmount = 0;
        }
        public decimal? TodayAmount { get; set; }
        /// <summary>
        /// 对比金额
        /// </summary>
        public decimal? ContrastAmount { get; set; }
    }
    /// <summary>
    /// 数量趋势(今天,对比数量)
    /// </summary>
    public class LongTrend
    {
        public LongTrend()
        {
            this.TodayNumber = 0;
            this.ContrastNumber = 0;
        }
        public long? TodayNumber { get; set; }
        /// <summary>
        /// 对比数量
        /// </summary>
        public long? ContrastNumber { get; set; }
    }
}
