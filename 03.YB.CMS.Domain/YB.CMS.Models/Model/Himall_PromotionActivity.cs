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
    
    public partial class Himall_PromotionActivity
    {
        public Himall_PromotionActivity()
        {
            this.Himall_PromotionActivityItem = new HashSet<Himall_PromotionActivityItem>();
        }
    
        public int Id { get; set; }
        public string ActivityTitle { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public int ActivityKey { get; set; }
        public decimal ActivityValue { get; set; }
        public long ShopId { get; set; }
        public string ActivityAd { get; set; }
        public int ActivityType { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public int IsAll { get; set; }
        public int OtherType { get; set; }
    
        public virtual ICollection<Himall_PromotionActivityItem> Himall_PromotionActivityItem { get; set; }
    }
}
