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
    
    public partial class Himall_CashDeposit
    {
        public Himall_CashDeposit()
        {
            this.Himall_CashDepositDetail = new HashSet<Himall_CashDepositDetail>();
        }
    
        public long Id { get; set; }
        public long ShopId { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal TotalBalance { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual ICollection<Himall_CashDepositDetail> Himall_CashDepositDetail { get; set; }
        public virtual Himall_Shops Himall_Shops { get; set; }
    }
}
