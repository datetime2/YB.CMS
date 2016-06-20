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
        public decimal OrderTotalPrice { get { return this.ProductTotalAmount + this.PushCustomsTax + this.Freight; } }
        public string ShopName { get; set; }
        public string OrderStatus { get; set; }
    }
}
