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
    
    public partial class Himall_PmailCecord
    {
        public long Id { get; set; }
        public Nullable<long> PId { get; set; }
        public string Time { get; set; }
        public string PhoId { get; set; }
        public int CecordStatus { get; set; }
    
        public virtual Himall_Pmail Himall_Pmail { get; set; }
    }
}
