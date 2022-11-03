using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Promotion;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionDiscountDto : PromotionBaseDto
    {
        public decimal? Price { get; set; }
        public decimal? DiscountAbsolute { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountMax { get; set; }
        public bool IsSpecialPrice { get; set; }

        public int? ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }
        public int? AssortmentId { get; set; }
        public PromotionAssortmentViewModel Assortment { get; set; }
        public int? ComboPromotionId { get; set; }
        public PromotionBaseViewModel ComboPromotion { get; set; }
    }
}
