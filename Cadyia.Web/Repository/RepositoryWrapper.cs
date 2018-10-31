using Cadyia.Web.Contracts;
using Cadyia.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private CadyiaDbContext _repoContext;
        private IPlanRepository _plan;
        private IUserProfileRepository _userProfile;
 
        public IPlanRepository Plan {
            get {
                if(_plan == null)
                {
                    _plan = new PlanRepository(_repoContext);
                }
 
                return _plan;
            }
        }
 
        public IUserProfileRepository UserProfile {
            get {
                if(_userProfile == null)
                {
                    _userProfile = new UserProfileRepository(_repoContext);
                }
 
                return _userProfile;
            }
        }
 
        public RepositoryWrapper(CadyiaDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
