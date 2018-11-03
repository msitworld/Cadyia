using System;
using System.Collections.Generic;
using System.Text;
using Cadyia.Data.Entities;
using Cadyia.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cadyia.Web.Data
{
    public partial class CadyiaDbContext : IdentityDbContext
    {
        #region Ctor
        public CadyiaDbContext(DbContextOptions<CadyiaDbContext> options)
            : base(options)
        {
        }
        #endregion

        #region DbSets
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanDownload> PlanDownloads { get; set; }
        public DbSet<PlanView> PlanViews { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        #endregion

        #region Configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Language

            #endregion

            #region Plan
            modelBuilder.Entity<Plan>()
                .Property(c => c.SubmitDate)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Plan>()
                .Property(c => c.Free)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("1");

            modelBuilder.Entity<Plan>()
                .Property(c => c.View)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            #endregion

            #region PlanDownload
            modelBuilder.Entity<PlanDownload>()
                   .HasOne(c => c.User)
                   .WithMany(c => c.PlanDownloads)
                   .HasForeignKey(c => c.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanDownload>()
                   .HasOne(c => c.Plan)
                   .WithMany(c => c.PlanDownloads)
                   .HasForeignKey(c => c.PlanId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanDownload>()
                   .HasKey(c => new { c.PlanId, c.UserId });
            #endregion

            #region PlanGlobal
            modelBuilder.Entity<PlanGlobal>()
                    .HasOne(c => c.Plan)
                    .WithMany(c => c.PlanGlobals)
                    .HasForeignKey(c => c.PlanId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanGlobal>()
                   .HasKey(c => new { c.PlanId, c.LanguageId });

            #endregion

            #region PlanView
            modelBuilder.Entity<PlanView>()
                   .HasOne(c => c.User)
                   .WithMany(c => c.PlanViews)
                   .HasForeignKey(c => c.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanView>()
                   .HasOne(c => c.Plan)
                   .WithMany(c => c.PlanViews)
                   .HasForeignKey(c => c.PlanId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanView>()
                   .HasKey(c => new { c.PlanId, c.UserId });
            #endregion

            #region UserContact
            modelBuilder.Entity<UserContact>()
                    .HasOne(c => c.User)
                    .WithMany(c => c.UserContacts)
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserContact>()
                    .HasOne(c => c.Contact)
                    .WithMany(c => c.UserContacts)
                    .HasForeignKey(c => c.ContactId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserContact>()
                   .HasKey(c => new { c.ContactId, c.UserId });
            #endregion


            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
