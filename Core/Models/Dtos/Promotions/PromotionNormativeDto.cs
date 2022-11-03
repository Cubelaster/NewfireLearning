using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Promotion;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionNormativeDto : PromotionBaseDto
    {
        public decimal Quantity { get; set; }
        public decimal PriceContribution { get; set; }

        public int? ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }
        public int? AssortmentId { get; set; }
        public PromotionAssortmentViewModel Assortment { get; set; }
    }
}
