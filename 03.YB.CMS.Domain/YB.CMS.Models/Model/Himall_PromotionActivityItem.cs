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
    
    public partial class Himall_PromotionActivityItem
    {
        public long Id { get; set; }
        public int ActivityId { get; set; }
        public long ProductId { get; set; }
        public decimal ActivityPrice { get; set; }
        public decimal ShareMoney { get; set; }
        public int SaleCount { get; set; }
        public decimal PushCustomsPrice { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public int ProductType { get; set; }
    
        public virtual Himall_Products Himall_Products { get; set; }
        public virtual Himall_PromotionActivity Himall_PromotionActivity { get; set; }
    }
}