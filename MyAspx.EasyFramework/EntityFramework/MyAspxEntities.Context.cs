﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
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
    
        public virtual DbSet<my_class> my_class { get; set; }
        public virtual DbSet<my_downurl> my_downurl { get; set; }
        public virtual DbSet<my_fileinfo> my_fileinfo { get; set; }
        public virtual DbSet<my_gold> my_gold { get; set; }
        public virtual DbSet<my_manage> my_manage { get; set; }
        public virtual DbSet<my_message> my_message { get; set; }
        public virtual DbSet<my_pay> my_pay { get; set; }
        public virtual DbSet<my_role> my_role { get; set; }
        public virtual DbSet<my_saletype> my_saletype { get; set; }
        public virtual DbSet<my_siteconf> my_siteconf { get; set; }
        public virtual DbSet<my_tag> my_tag { get; set; }
        public virtual DbSet<my_users> my_users { get; set; }
        public virtual DbSet<my_filecost> my_filecost { get; set; }
    }
}
