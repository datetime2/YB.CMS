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
    
    public partial class Himall_VShopExtend
    {
        public long Id { get; set; }
        public long VShopId { get; set; }
        public Nullable<int> Sequence { get; set; }
        public int Type { get; set; }
        public System.DateTime AddTime { get; set; }
        public int State { get; set; }
    
        public virtual Himall_VShop Himall_VShop { get; set; }
    }
}
