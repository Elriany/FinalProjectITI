﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolDBEntities : DbContext
    {
        public SchoolDBEntities()
            : base("name=SchoolDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<ClassLevel> ClassLevels { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<fee> fees { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<parent> parents { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<std_Crs> std_Crs { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<tbl_absence> tbl_absence { get; set; }
        public virtual DbSet<tbl_role> tbl_role { get; set; }
        public virtual DbSet<tbl_Task> tbl_Task { get; set; }
        
    }
}
