using Core.Models.ViewModels.Partner;
using Core.Models.ViewModels.Site;

namespace Core.Models.Dtos.Partner
{
    public class PartnerSiteDto
    {
        public int? Id { get; set; }
        public int PartnerId { get; set; }
        public PartnerBaseViewModel Partner { get; set; }
        public int SiteId { get; set; }
        public SiteBaseViewModel Site { get; set; }
    }
}
