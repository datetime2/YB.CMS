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
    
    public partial class Himall_FreightAreaContent
    {
        public long Id { get; set; }
        public long FreightTemplateId { get; set; }
        public string AreaContent { get; set; }
        public Nullable<int> FirstUnit { get; set; }
        public Nullable<float> FirstUnitMonry { get; set; }
        public Nullable<int> AccumulationUnit { get; set; }
        public Nullable<float> AccumulationUnitMoney { get; set; }
        public Nullable<sbyte> IsDefault { get; set; }
    
        public virtual Himall_FreightTemplate Himall_FreightTemplate { get; set; }
    }
}
