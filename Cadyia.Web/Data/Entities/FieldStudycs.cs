using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadyia.Data.Entities
{
    [NotMapped]
    public partial class FieldStudy
    {
        public int FieldStudyId { get; set; }
        public int? ParentFieldStudyId { get; set; }
        public string FieldStudyTitle { get; set; }

        public virtual ICollection<FieldStudy> FieldStudies { get; set; }
    }
}

