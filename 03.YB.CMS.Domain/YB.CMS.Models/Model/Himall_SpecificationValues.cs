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
    
    public partial class Himall_SpecificationValues
    {
        public Himall_SpecificationValues()
        {
            this.Himall_SellerSpecificationValues = new HashSet<Himall_SellerSpecificationValues>();
        }
    
        public long Id { get; set; }
        public int Specification { get; set; }
        public long TypeId { get; set; }
        public string Value { get; set; }
    
        public virtual ICollection<Himall_SellerSpecificationValues> Himall_SellerSpecificationValues { get; set; }
        public virtual Himall_Types Himall_Types { get; set; }
    }
}
