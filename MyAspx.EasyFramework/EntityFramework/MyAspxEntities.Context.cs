﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAspx.EasyFramework.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class commyaspxdbEntities : DbContext
    {
        public commyaspxdbEntities()
            : base("name=commyaspxdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<my_class> my_class { get; set; }
        public DbSet<my_downurl> my_downurl { get; set; }
        public DbSet<my_fileinfo> my_fileinfo { get; set; }
        public DbSet<my_gold> my_gold { get; set; }
        public DbSet<my_manage> my_manage { get; set; }
        public DbSet<my_message> my_message { get; set; }
        public DbSet<my_pay> my_pay { get; set; }
        public DbSet<my_role> my_role { get; set; }
        public DbSet<my_siteconf> my_siteconf { get; set; }
        public DbSet<my_tag> my_tag { get; set; }
        public DbSet<my_users> my_users { get; set; }
    }
}