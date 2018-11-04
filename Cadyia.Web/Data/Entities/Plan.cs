using Cadyia.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadyia.Web.Data.Entities
{
    public class Plan
    {
        public Plan()
        {
            SubmitDate = DateTime.Now;
            View = 0;
            Free = true;
            PresentOnly = false;
            Show = true;
        }

        public int PlanId { get; set; }
        [MaxLength(450), ForeignKey("User")]
        public string UserId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime SubmitDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ApproveDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? ShowDate { get; set; }
        public int View { get; set; }
        public int? ImageId { get; set; }
        public bool Free { get; set; }
        public bool PresentOnly { get; set; }
        public bool? Approve { get; set; }
        public int? ApprovedBy { get; set; }
        public string RejectCause { get; set; }
        public bool Show { get; set; }

        public virtual User User { get; set; }
        //public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PlanView> PlanViews { get; set; }
        public virtual ICollection<PlanDownload> PlanDownloads { get; set; }
        public virtual ICollection<PlanGlobal> PlanGlobals { get; set; }
        public virtual ICollection<PlanLike> PlanLikes { get; set; }
        /*public virtual ICollection<ModelLike> ModelLikes { get; set; }
        public virtual ICollection<PlanDownload> PlanDownloads { get; set; }
        public virtual ICollection<ModelFile> ModelFiles { get; set; }
        public virtual ICollection<ModelCurrency> ModelCurrencies { get; set; }
        public virtual ICollection<ModelCategory> ModelCategories { get; set; }
        public virtual ICollection<ModelSoftware> ModelSoftwares { get; set; }
        public virtual ICollection<ModelProperty> ModelProperties { get; set; }
        public virtual ICollection<ModelRate> ModelRates { get; set; }
        public virtual ICollection<ModelTag> ModelTags { get; set; }
        public virtual ICollection<ModelFileFormat> ModelFileFormats { get; set; }
        public virtual ICollection<File> Files { get; set; }*/
    }
}
