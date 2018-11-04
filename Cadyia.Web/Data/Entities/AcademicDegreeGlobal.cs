using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class AcademicDegreeGlobal
    {
        [Column(Order = 1)]
        public int AcademicDegreeId { get; set; }
        [Column(Order = 2)]
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public virtual AcademicDegree AcademicDegree { get; set; }
        public virtual Language Language { get; set; }
    }
}
