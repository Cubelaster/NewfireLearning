namespace Core.Models.EfModels.Promotions
{
    public class PromotionSite : PromotionChild
    {
        public int SiteId { get; set; }
        public Site Site { get; set; }
    }
}
