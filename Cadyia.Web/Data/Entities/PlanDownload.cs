using Cadyia.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class PlanDownload
    {
        [Column(Order = 1)]
        public int PlanId { get; set; }
        [Column(Order = 2)]
        [MaxLength(450), ForeignKey("User")]
        public string UserId { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual User User { get; set; }

    }
}
