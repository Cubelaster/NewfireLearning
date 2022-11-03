using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class SiteSiteContent : DatabaseEntity<int>
    {
        public int SiteId { get; set; }
        public Site Site { get; set; }

        public int SiteContentId { get; set; }
        public SiteContent SiteContent { get; set; }
    }
}
