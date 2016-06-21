﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YB.CMS.Models.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Himall_OrderItems
    {
        public Himall_OrderItems()
        {
            this.Himall_OrderRefunds = new HashSet<Himall_OrderRefunds>();
            this.Himall_ProductComments = new HashSet<Himall_ProductComments>();
        }
    
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ShopId { get; set; }
        public long ProductId { get; set; }
        public string SkuId { get; set; }
        public string SKU { get; set; }
        public long Quantity { get; set; }
        public long ReturnQuantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal RealTotalPrice { get; set; }
        public decimal RefundPrice { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Version { get; set; }
        public string ThumbnailsUrl { get; set; }
        public decimal CommisRate { get; set; }
        public Nullable<decimal> EnabledRefundAmount { get; set; }
        public bool IsLimitBuy { get; set; }
        public decimal ShareMoney { get; set; }
        public string TaxPrice { get; set; }
        public int TaxRate { get; set; }
        public decimal Tax { get; set; }
        public Nullable<decimal> MarketPrice { get; set; }
        public Nullable<long> RefundId { get; set; }
        public int IsVirtualProduct { get; set; }
        public long BaseOrderItemId { get; set; }
        public Nullable<decimal> AfterSharePrice { get; set; }
        public decimal PushCustomsPrice { get; set; }
        public decimal PushCustomsTax { get; set; }
        public long ActivityId { get; set; }
    
        public virtual Himall_Orders Himall_Orders { get; set; }
        public virtual ICollection<Himall_OrderRefunds> Himall_OrderRefunds { get; set; }
        public virtual ICollection<Himall_ProductComments> Himall_ProductComments { get; set; }
    }
}
