using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class Contact
    {
        public Contact()
        {
            Status = true;
        }

        public int ContactId { get; set; }
        public string ContactTitle { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
    }
}
