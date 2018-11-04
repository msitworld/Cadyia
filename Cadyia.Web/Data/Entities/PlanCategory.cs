using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class PlanCategory
    {
        public int PlanId { get; set; }
        public int CategoryId { get; set; }

        public virtual Plan Plan { get; set; }
        public virtual Category Category { get; set; }
    }
}
