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
    
    public partial class Himall_ModuleStaticPageProducts
    {
        public long Id { get; set; }
        public long StaPagModuleId { get; set; }
        public long ProductId { get; set; }
        private string pcImage { get; set; }
        public string PCLinkURL { get; set; }
        public long DisplaySequence { get; set; }
        public string PlatForm { get; set; }
        public string WAPLinkURL { get; set; }
        private string wapImage { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string DomainName { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public string AppLinkUrl { get; set; }
        public decimal SinglePrice { get; set; }
    
        public virtual Himall_StaticPageConfigModules Himall_StaticPageConfigModules { get; set; }
    }
}
