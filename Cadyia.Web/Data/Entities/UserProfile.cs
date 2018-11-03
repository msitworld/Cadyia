using Cadyia.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadyia.Data.Entities
{
    public class UserProfile
    {
        public UserProfile()
        {
            ProfileView = 0;
        }

        [Key]
        [MaxLength(450), ForeignKey("User")]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public string Location { get; set; }
        public string EnAliasName { get; set; }
        public string LocalAliasName { get; set; }
        [ForeignKey("FieldStudy")]
        public int? FieldStudyId { get; set; }
        [ForeignKey("AcademicDegree")]
        public int? AcademicDegreeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Biography { get; set; }
        public int ProfileView { get; set; }

        public virtual AcademicDegree AcademicDegree { get; set; }
        public virtual FieldStudy FieldStudy { get; set; }
        public virtual User User { get; set; }

    }

}
