using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Model
{
    public class Himall_Distributor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public string ProvinceCode { get; set; }
        public string CityCode { get; set; }
        public string OwnerName { get; set; }
        public string IDCard { get; set; }
        public string LinkTel { get; set; }
        public Nullable<int> IsUse { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> ChargeType { get; set; }
        public Nullable<decimal> ChargeRate { get; set; }
        public string IDCard_Pic { get; set; }
        public string IDCard_Pic2 { get; set; }
        public Nullable<int> LevelId { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int CodeNumber { get; set; }
        public Nullable<System.DateTime> CodeTime { get; set; }
    }
}
