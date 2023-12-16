﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolunProject.Data.EntityADO.NET
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VolunteerDBEntities : DbContext
    {
        public VolunteerDBEntities()
            : base("name=VolunteerDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<QuanHuyen> QuanHuyens { get; set; }
        public DbSet<QuocGia> QuocGias { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewList> ReviewLists { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<SysIndex> SysIndexes { get; set; }
        public DbSet<TinhThanhPho> TinhThanhPhoes { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<VolunteerLikeEvent> VolunteerLikeEvents { get; set; }
        public DbSet<VolunteerReward> VolunteerRewards { get; set; }
        public DbSet<XaPhuong> XaPhuongs { get; set; }
    }
}
