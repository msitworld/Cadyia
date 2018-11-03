using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class UserContact
    {
        public UserContact()
        {
            IsVerify = false;
        }

        [Column(Order = 0)]
        public int ContactId { get; set; }
        [Column(Order = 1)]
        [MaxLength(450), ForeignKey("User")]
        public string UserId { get; set; }
        public string ContactValue { get; set; }
        public string VerifyCode { get; set; }
        public bool IsVerify { get; set; }

        public virtual User User { get; set; }
        public virtual Contact Contact { get; set; }
    }
}