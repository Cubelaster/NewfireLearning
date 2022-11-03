namespace Core.Models.EfModels.Promotions
{
    public class PromotionDiscount : PromotionChildWithArticle
    {
        public decimal? Price { get; set; }
        public decimal? DiscountAbsolute { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountMax { get; set; }

        public bool IsSpecialPrice { get; set; }

        public int? ComboPromotionId { get; set; }
        public Promotion ComboPromotion { get; set; }
    }
}
