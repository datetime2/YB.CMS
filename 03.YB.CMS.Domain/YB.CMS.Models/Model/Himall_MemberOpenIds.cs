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
    public partial class Himall_MemberOpenIds
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string OpenId { get; set; }
        public string ServiceProvider { get; set; }
        public AppIdTypeEnum AppIdType { get; set; }
    
        public virtual Himall_Members Himall_Members { get; set; }
    }
}
