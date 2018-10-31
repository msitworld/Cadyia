using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadyia.Data.Entities
{
    public class UserProfile
    {
        [Key]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public string Location { get; set; }
        public string AliasName { get; set; }
        [ForeignKey("FieldStudy")]
        public int? FieldStudyID { get; set; }
        [ForeignKey("AcademicDegree")]
        public int? AcademicDegreeID { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Biography { get; set; }
        public int? ProfileView { get; set; }

        public virtual AcademicDegree AcademicDegree { get; set; }
        public virtual FieldStudy FieldStudy { get; set; }

    }

}
