namespace Cadyia.Web.Data.Entities
{
    public class PlanGlobal
    {
        public int PlanId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual Language Language { get; set; }


    }
}
