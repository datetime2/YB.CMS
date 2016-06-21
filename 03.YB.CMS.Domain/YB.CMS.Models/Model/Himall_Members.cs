﻿//------------------------------------------------------------------------------
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
    
    public partial class Himall_Members
    {
        public Himall_Members()
        {
            this.Himall_BrowsingHistory = new HashSet<Himall_BrowsingHistory>();
            this.Himall_Favorites = new HashSet<Himall_Favorites>();
            this.Himall_MemberAccount = new HashSet<Himall_MemberAccount>();
            this.Himall_MemberIncom = new HashSet<Himall_MemberIncom>();
            this.Himall_MemberIntegral = new HashSet<Himall_MemberIntegral>();
            this.Himall_MemberOpenIds = new HashSet<Himall_MemberOpenIds>();
            this.Himall_ProductComments = new HashSet<Himall_ProductComments>();
            this.Himall_ShippingAddresses = new HashSet<Himall_ShippingAddresses>();
            this.Himall_ShoppingCarts = new HashSet<Himall_ShoppingCarts>();
            this.Himall_MemberIntegralRecord = new HashSet<Himall_MemberIntegralRecord>();
            this.Himall_FocusBrand = new HashSet<Himall_FocusBrand>();
        }
    
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int TopRegionId { get; set; }
        public int RegionId { get; set; }
        public string RealName { get; set; }
        public string CellPhone { get; set; }
        public string QQ { get; set; }
        public string Address { get; set; }
        public bool Disabled { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public int OrderNumber { get; set; }
        public decimal Expenditure { get; set; }
        public int Points { get; set; }
        public string photo { get; set; }
        public long ParentSellerId { get; set; }
        public string Remark { get; set; }
        public string IDAddress { get; set; }
        public string IDCard { get; set; }
        public long DistributorId { get; set; }
        public Nullable<long> ReferrerID { get; set; }
        public string FamilyTree { get; set; }
        public Nullable<int> RegSource { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Birth { get; set; }
        public string Sex { get; set; }
        public string Domainname { get; set; }
        public string TradePassword { get; set; }
        public string TradePasswordSalt { get; set; }
        public Nullable<int> SourceId { get; set; }
        public int IsSuperReferr { get; set; }
        public int LoginCount { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public int CommunityReferRate { get; set; }
    
        public virtual ICollection<Himall_BrowsingHistory> Himall_BrowsingHistory { get; set; }
        public virtual Himall_Distributor Himall_Distributor { get; set; }
        public virtual ICollection<Himall_Favorites> Himall_Favorites { get; set; }
        public virtual ICollection<Himall_MemberAccount> Himall_MemberAccount { get; set; }
        public virtual ICollection<Himall_MemberIncom> Himall_MemberIncom { get; set; }
        public virtual ICollection<Himall_MemberIntegral> Himall_MemberIntegral { get; set; }
        public virtual ICollection<Himall_MemberOpenIds> Himall_MemberOpenIds { get; set; }
        public virtual ICollection<Himall_ProductComments> Himall_ProductComments { get; set; }
        public virtual ICollection<Himall_ShippingAddresses> Himall_ShippingAddresses { get; set; }
        public virtual ICollection<Himall_ShoppingCarts> Himall_ShoppingCarts { get; set; }
        public virtual ICollection<Himall_MemberIntegralRecord> Himall_MemberIntegralRecord { get; set; }
        public virtual ICollection<Himall_FocusBrand> Himall_FocusBrand { get; set; }
    }
}
