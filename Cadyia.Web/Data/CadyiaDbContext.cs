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
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<AcademicDegreeGlobal> AcademicDegreeGlobals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryGlobal> CategoryGlobals { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FieldStudy> FieldStudies { get; set; }
        public DbSet<FieldStudyGlobal> FieldStudyGlobals { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanCategory> PlanCategories { get; set; }
        public DbSet<PlanDownload> PlanDownloads { get; set; }
        public DbSet<PlanLike> PlanLikes { get; set; }
        public DbSet<PlanView> PlanViews { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<SoftwareVersion> SoftwareVersions { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        #endregion

        #region Configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region AcademicDegreeGlobal
            modelBuilder.Entity<AcademicDegreeGlobal>()
                    .HasOne(c => c.AcademicDegree)
                    .WithMany(c => c.AcademicDegreeGlobals)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AcademicDegreeGlobal>()
                   .HasKey(c => new { c.AcademicDegreeId, c.LanguageId });
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
                    .HasMany(c => c.Categories)
                    .WithOne()
                    .HasForeignKey(c => c.ParentCategoryId)
                    .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Category>()
                      .HasOne(c => c.User)
                      .WithMany(c => c.Categories)
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region CategoryGlobal
            modelBuilder.Entity<CategoryGlobal>()
                    .HasOne(c => c.Category)
                    .WithMany(c => c.CategoryGlobals)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CategoryGlobal>()
                   .HasKey(c => new { c.CategoryId, c.LanguageId });

            #endregion

            #region FieldStudy
            /*modelBuilder.Entity<FieldStudy>()
                    .HasOne(c => c.FieldStudies)
                    .WithMany()
                    .HasForeignKey(c => c.ParentFieldStudyId)
                    .OnDelete(DeleteBehavior.SetNull);*/
            #endregion

            #region FieldStudyGlobal
            modelBuilder.Entity<FieldStudyGlobal>()
                    .HasOne(c => c.FieldStudy)
                    .WithMany(c => c.FieldStudyGlobals)
                    .HasForeignKey(c => c.FieldStudyId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FieldStudyGlobal>()
                   .HasKey(c => new { c.FieldStudyId, c.LanguageId });
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

            #region PlanCategory
            modelBuilder.Entity<PlanCategory>()
                   .HasKey(c => new { c.PlanId, c.CategoryId });

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

            #region PlanLike
            modelBuilder.Entity<PlanLike>()
                   .HasOne(c => c.User)
                   .WithMany(c => c.PlanLikes)
                   .HasForeignKey(c => c.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanLike>()
                   .HasOne(c => c.Plan)
                   .WithMany(c => c.PlanLikes)
                   .HasForeignKey(c => c.PlanId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanLike>()
                   .HasKey(c => new { c.PlanId, c.UserId });
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

            #region Software
            modelBuilder.Entity<Software>()
                      .HasOne(c => c.User)
                      .WithMany(c => c.Softwares)
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region SoftwareVersion
            modelBuilder.Entity<SoftwareVersion>()
                      .HasOne(c => c.User)
                      .WithMany(c => c.SoftwareVersions)
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.SetNull);
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
