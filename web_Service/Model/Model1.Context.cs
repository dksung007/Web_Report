﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_Service.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_EF : DbContext
    {
        public DB_EF()
            : base("name=DB_EF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Log_FORD> Log_FORD { get; set; }
        public virtual DbSet<Log_P375> Log_P375 { get; set; }
        public virtual DbSet<Log_U375> Log_U375 { get; set; }
        public virtual DbSet<tb_bom_ford1> tb_bom_ford1 { get; set; }
        public virtual DbSet<tb_bom_t6> tb_bom_t6 { get; set; }
        public virtual DbSet<tb_bom_u375> tb_bom_u375 { get; set; }
        public virtual DbSet<tb_cf_part> tb_cf_part { get; set; }
        public virtual DbSet<tb_st_p375> tb_st_p375 { get; set; }
        public virtual DbSet<tb_st_part> tb_st_part { get; set; }
        public virtual DbSet<tb_st_u375> tb_st_u375 { get; set; }
    }
}