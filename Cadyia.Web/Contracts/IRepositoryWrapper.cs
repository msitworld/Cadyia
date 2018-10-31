using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Contracts
{
    public interface IRepositoryWrapper
    {
        IPlanRepository Plan { get; }
        IUserProfileRepository UserProfile { get; }
    }
}
