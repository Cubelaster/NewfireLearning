using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class SiteAssortment : DatabaseEntity<int>
    {
        public int SiteId { get; set; }
        public Site Site { get; set; }

        public int AssortmentId { get; set; }
        public Assortment Assortment { get; set; }
    }
}
