namespace Core.Models.EfModels.Promotions
{
    public class PromotionNormative : PromotionChildWithArticle
    {
        public decimal Quantity { get; set; }
        public decimal PriceContribution { get; set; }
    }
}
