//------------------------------------------------------------------------------
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
    
    public partial class Himall_AccountDetails
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ShopId { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int OrderType { get; set; }
        public long OrderId { get; set; }
        public decimal ProductActualPaidAmount { get; set; }
        public decimal FreightAmount { get; set; }
        public decimal CommissionAmount { get; set; }
        public decimal RefundTotalAmount { get; set; }
        public decimal RefundCommisAmount { get; set; }
        public string OrderRefundsDates { get; set; }
    
        public virtual Himall_Accounts Himall_Accounts { get; set; }
    }
}
