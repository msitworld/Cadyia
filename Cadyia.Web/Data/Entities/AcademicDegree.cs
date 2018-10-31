using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadyia.Data.Entities
{
    [NotMapped]
    public partial class AcademicDegree
    {
        public int AcademicDegreeId { get; set; }
        public string AcademicDegreeTitle { get; set; }
    }
}
