using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Promotion;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionConditionDto : PromotionBaseDto
    {
        public decimal? QuantityFrom { get; set; }
        public decimal? QuantityTo { get; set; }

        public decimal? ValueFrom { get; set; }
        public decimal? ValueTo { get; set; }

        public decimal? DiscountContribution { get; set; }
        public decimal? DiscountQuanitiy { get; set; }

        public bool CheckComboItems { get; set; }

        public int? ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }
        public int? AssortmentId { get; set; }
        public PromotionAssortmentViewModel Assortment { get; set; }
    }
}
