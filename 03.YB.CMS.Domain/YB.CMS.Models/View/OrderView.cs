using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.View
{
    public class OrderView
    {
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string DistributorName { get; set; }
        public string UserName { get; set; }
        public string ShipTo { get; set; }
        public decimal ProductTotalAmount { get; set; }
        public decimal PushCustomsTax { get; set; }
        public decimal Freight { get; set; }
        /// <summary>
        /// 订单总额
        /// </summary>
        public decimal OrderTotalPrice { get { return this.ProductTotalAmount + this.PushCustomsTax + this.Freight; } }
        public decimal IntegralDiscount { get; set; }
        public decimal DiscountAmount { get; set; }
        /// <summary>
        /// 订单实付金额
        /// </summary>
        public decimal OrderTotalPay
        {
            get
            {
                return this.ProductTotalAmount + this.Freight + this.PushCustomsTax - this.IntegralDiscount - this.DiscountAmount;
            }
        }
        public string ShopName { get; set; }
        public string OrderStatus { get; set; }
        public string IsPush { get; set; }
        public string PlatFrom { get; set; }
    }
}
