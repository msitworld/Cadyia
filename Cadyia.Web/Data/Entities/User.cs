using Cadyia.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadyia.Web.Data.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<PlanView> PlanViews { get; set; }
        public virtual ICollection<PlanDownload> PlanDownloads { get; set; }
        public virtual ICollection<PlanLike> PlanLikes { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
        public virtual ICollection<SoftwareVersion> SoftwareVersions { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        /*public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Follow> Followers { get; set; }
        public virtual ICollection<Follow> Followings { get; set; }
        public virtual ICollection<Connection> Connections { get; set; }
        public virtual ICollection<UserCategory> UserCategories { get; set; }
        public virtual ICollection<UserSoftware> UserSoftwares { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        //public virtual ICollection<Trade> Trades { get; set; }
        public virtual ICollection<UserFile> UserFiles { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectFreelance> ProjectFreelances { get; set; }
        public virtual ICollection<ProjectView> ProjectViews { get; set; }
        public virtual ICollection<ProjectMark> ProjectMarks { get; set; }
        //public virtual ICollection<Trade> Trades { get; set; }
        public virtual ICollection<CFile> CFiles { get; set; }
        public virtual ICollection<Conversation> Conversations { get; set; }
        public virtual ICollection<DraftMessage> DraftMessages { get; set; }
        public virtual ICollection<UserConversation> UserConversations { get; set; }*/

    }
}
