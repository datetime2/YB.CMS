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
    
    public partial class Himall_ProductComments
    {
        public long Id { get; set; }
        public Nullable<long> SubOrderId { get; set; }
        public long ProductId { get; set; }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ReviewContent { get; set; }
        public System.DateTime ReviewDate { get; set; }
        public int ReviewMark { get; set; }
        public string ReplyContent { get; set; }
        public Nullable<System.DateTime> ReplyDate { get; set; }
        public int CommentStatus { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public string Images { get; set; }
        public string ImagePath { get; set; }
        public string DomainName { get; set; }
        public int CommentType { get; set; }
    
        public virtual Himall_Members Himall_Members { get; set; }
        public virtual Himall_OrderItems Himall_OrderItems { get; set; }
        public virtual Himall_Products Himall_Products { get; set; }
        public virtual Himall_Shops Himall_Shops { get; set; }
    }
}
