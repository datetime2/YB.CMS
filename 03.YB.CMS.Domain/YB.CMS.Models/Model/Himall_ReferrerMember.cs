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
    using static Enum.UserEnum;
    public partial class Himall_ReferrerMember
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string CardNo { get; set; }
        public string ApplyReason { get; set; }
        public Nullable<System.DateTime> ApplyTime { get; set; }
        public ReferrAuditStatus Available { get; set; }
        public string ReferURL { get; set; }
        public string ReferImage { get; set; }
        public Nullable<long> ReferrerID { get; set; }
        public string RefusalReason { get; set; }
        public string RealName { get; set; }
        public string CellPhone { get; set; }
    }
}
