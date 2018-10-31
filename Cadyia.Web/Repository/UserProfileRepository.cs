using Cadyia.Data.Entities;
using Cadyia.Web.Contracts;
using Cadyia.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Repository
{
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(CadyiaDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}