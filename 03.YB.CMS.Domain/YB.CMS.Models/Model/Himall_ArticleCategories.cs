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
    
    public partial class Himall_ArticleCategories
    {
        public Himall_ArticleCategories()
        {
            this.Himall_Articles = new HashSet<Himall_Articles>();
        }
    
        public long Id { get; set; }
        public long ParentCategoryId { get; set; }
        public string Name { get; set; }
        public long DisplaySequence { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual ICollection<Himall_Articles> Himall_Articles { get; set; }
    }
}
