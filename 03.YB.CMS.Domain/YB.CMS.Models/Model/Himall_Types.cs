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
    
    public partial class Himall_Types
    {
        public Himall_Types()
        {
            this.Himall_Attributes = new HashSet<Himall_Attributes>();
            this.Himall_Categories = new HashSet<Himall_Categories>();
            this.Himall_SpecificationValues = new HashSet<Himall_SpecificationValues>();
            this.Himall_TypeBrands = new HashSet<Himall_TypeBrands>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsSupportColor { get; set; }
        public bool IsSupportSize { get; set; }
        public bool IsSupportVersion { get; set; }
    
        public virtual ICollection<Himall_Attributes> Himall_Attributes { get; set; }
        public virtual ICollection<Himall_Categories> Himall_Categories { get; set; }
        public virtual ICollection<Himall_SpecificationValues> Himall_SpecificationValues { get; set; }
        public virtual ICollection<Himall_TypeBrands> Himall_TypeBrands { get; set; }
    }
}
