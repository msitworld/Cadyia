using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class CategoryGlobal
    {
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }

    }
}
