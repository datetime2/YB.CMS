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
    
    public partial class Himall_DistributorSettlement
    {
        public long Id { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<long> BeginId { get; set; }
        public Nullable<long> EndId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string OperateName { get; set; }
        public string PayPeople { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string Remarks { get; set; }
        public long DistributorId { get; set; }
        public string DistributorProfitIds { get; set; }
    
        public virtual Himall_Distributor Himall_Distributor { get; set; }
    }
}