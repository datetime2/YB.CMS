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
    
    public partial class Himall_Attributes
    {
        public Himall_Attributes()
        {
            this.Himall_AttributeValues = new HashSet<Himall_AttributeValues>();
            this.Himall_ProductAttributes = new HashSet<Himall_ProductAttributes>();
        }
    
        public long Id { get; set; }
        public long TypeId { get; set; }
        public string Name { get; set; }
        public long DisplaySequence { get; set; }
        public bool IsMust { get; set; }
        public bool IsMulti { get; set; }
    
        public virtual Himall_Types Himall_Types { get; set; }
        public virtual ICollection<Himall_AttributeValues> Himall_AttributeValues { get; set; }
        public virtual ICollection<Himall_ProductAttributes> Himall_ProductAttributes { get; set; }
    }
}
