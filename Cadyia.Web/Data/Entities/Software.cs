using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class Software
    {
        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }
        public bool Status { get; set; }

        public virtual User User { get; set; }
        //public ICollection<ModelSoftware> ModelSoftwares { get; set; }
        //public ICollection<ProjectSoftware> ProjectSoftwares { get; set; }

        public ICollection<SoftwareVersion> Versions { get; set; }
    }
}
