﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WSDBEntities : DbContext
    {
        public WSDBEntities()
            : base("name=WSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account_QRCode_Template> Account_QRCode_Template { get; set; }
        public virtual DbSet<CashCouponRecords> CashCouponRecords { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Goods_Categorys> Goods_Categorys { get; set; }
        public virtual DbSet<Goods_SendWays> Goods_SendWays { get; set; }
        public virtual DbSet<OfficialAccounts> OfficialAccounts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<QRCode_Templates> QRCode_Templates { get; set; }
        public virtual DbSet<Subscribes> Subscribes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Users_Roles> Users_Roles { get; set; }
    }
}