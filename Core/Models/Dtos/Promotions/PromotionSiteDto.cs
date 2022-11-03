using Core.Models.ViewModels.Site;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionSiteDto : PromotionBaseDto
    {
        public int SiteId { get; set; }
        public SiteBaseViewModel Site { get; set; }
    }
}
