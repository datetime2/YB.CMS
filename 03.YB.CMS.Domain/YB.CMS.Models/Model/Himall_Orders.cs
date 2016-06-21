using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YB.CMS.Models.Enum.OrderEnum;

namespace YB.CMS.Models.Model
{
    public class Himall_Orders
    {
        public long Id { get; set; }
        public OrderOperateStatus OrderStatus { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string CloseReason { get; set; }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public string SellerPhone { get; set; }
        public string SellerAddress { get; set; }
        public string SellerRemark { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserRemark { get; set; }
        public string ShipTo { get; set; }
        public string CellPhone { get; set; }
        public int TopRegionId { get; set; }
        public int RegionId { get; set; }
        public string RegionFullName { get; set; }
        public string Address { get; set; }
        public string ExpressCompanyName { get; set; }
        public decimal Freight { get; set; }
        public string ShipOrderNumber { get; set; }
        public Nullable<System.DateTime> ShippingDate { get; set; }
        public bool IsPrinted { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentTypeGateway { get; set; }
        public string GatewayOrderId { get; set; }
        public string PayRemark { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public int InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public decimal Tax { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public decimal ProductTotalAmount { get; set; }
        public decimal RefundTotalAmount { get; set; }
        public decimal CommisTotalAmount { get; set; }
        public decimal RefundCommisAmount { get; set; }
        public int ActiveType { get; set; }
        public PlatformType Platform { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal IntegralDiscount { get; set; }
        public string InvoiceContext { get; set; }
        public int TradeType { get; set; }
        public string CustomsReMark { get; set; }
        public string CustomsStatus { get; set; }
        public long ParentOrderID { get; set; }
        public long DistributorID { get; set; }
        public string IDCard { get; set; }
        public string CustomsDisStatus { get; set; }
        public decimal PushCustomsTax { get; set; }
        public decimal PushCustomsTotalPrice { get; set; }
        public string Jnumber { get; set; }
        public string Score { get; set; }
        public long SellerId { get; set; }
        public string RelateOrderId { get; set; }
        public int RecycleBin { get; set; }
        public int IsPreSale { get; set; }
        public Nullable<System.DateTime> PreSaleEndDate { get; set; }
        public decimal OrderAmountRedundancy { get; set; }
        public int IsSubscribeExpress { get; set; }
        public decimal ActivityDiscount { get; set; }
        public int OrderType { get; set; }
        public int IsPush { get; set; }
        public string ActiveIds { get; set; }
    }
}
