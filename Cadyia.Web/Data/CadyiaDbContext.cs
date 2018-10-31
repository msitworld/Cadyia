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
    }
}
