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
    
    public partial class Himall_ProductDescriptions
    {
        public Nullable<long> Id { get; set; }
        public long ProductId { get; set; }
        public string AuditReason { get; set; }
        public string Description { get; set; }
        public long DescriptionPrefixId { get; set; }
        public long DescriptiondSuffixId { get; set; }
        public string Meta_Title { get; set; }
        public string Meta_Description { get; set; }
        public string Meta_Keywords { get; set; }
    
        public virtual Himall_Products Himall_Products { get; set; }
    }
}
