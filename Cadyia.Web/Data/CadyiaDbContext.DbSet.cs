using System;
using System.Collections.Generic;
using System.Text;
using Cadyia.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cadyia.Web.Data
{
    public partial class CadyiaDbContext : IdentityDbContext
    {
        public DbSet<Plan> Plans { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
