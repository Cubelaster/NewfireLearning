namespace Core.Models.EfModels.Promotions
{
    public class PromotionCondition : PromotionChildWithArticle
    {
        public decimal? QuantityFrom { get; set; }
        public decimal? QuantityTo { get; set; }

        public decimal? ValueFrom { get; set; }
        public decimal? ValueTo { get; set; }

        public decimal DiscountContribution { get; set; }
        public decimal DiscountQuanitiy { get; set; }

        public bool CheckComboItems { get; set; }
    }
}
