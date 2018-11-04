using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class SoftwareVersion
    {
        public int SoftwareVersionId { get; set; }
        public int SoftwareId { get; set; }
        public string VersionTitle { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public Software Software { set; get; }
        //public ICollection<ModelSoftware> ModelSoftwares { get; set; }
        //public ICollection<ProjectSoftware> ProjectSoftwares { get; set; }
    }
}
