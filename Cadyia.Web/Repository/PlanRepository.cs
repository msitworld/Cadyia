using Cadyia.Data.Entities;
using Cadyia.Web.Contracts;
using Cadyia.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Repository
{
    public class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        public PlanRepository(CadyiaDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
