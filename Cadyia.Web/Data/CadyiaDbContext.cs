using System;
using System.Collections.Generic;
using System.Text;
using Cadyia.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cadyia.Web.Data
{
    public class CadyiaDbContext : IdentityDbContext
    {
        public CadyiaDbContext(DbContextOptions<CadyiaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            base.OnModelCreating(modelBuilder);
        }
    }
}
