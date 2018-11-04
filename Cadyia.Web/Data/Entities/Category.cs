using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }
        public bool Status { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<CategoryGlobal> CategoryGlobals { get; set; }
        //public virtual ICollection<CategoryProperty> CategoryProperties { get; set; }
        //public virtual ICollection<CategorySoftware> CategorySoftwares { get; set; }
    }
}
