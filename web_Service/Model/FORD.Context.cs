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
    
    public partial class FORD_Entities : DbContext
    {
        public FORD_Entities()
            : base("name=FORD_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblFordTran> tblFordTrans { get; set; }
        public virtual DbSet<tblPart> tblParts { get; set; }
        public virtual DbSet<tblRackLbl> tblRackLbls { get; set; }
    }
}