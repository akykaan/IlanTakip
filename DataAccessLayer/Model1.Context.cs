﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IlanTakipDbEntities : DbContext
    {
        public IlanTakipDbEntities()
            : base("name=IlanTakipDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Cvs> Cvs { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<JobAdverts> JobAdverts { get; set; }
        public virtual DbSet<JobExperiences> JobExperiences { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<SubMenu> SubMenu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
    }
}
