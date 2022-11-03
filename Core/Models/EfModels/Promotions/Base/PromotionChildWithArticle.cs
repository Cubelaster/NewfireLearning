namespace Core.Models.EfModels.Promotions
{
    public class PromotionChildWithArticle : PromotionChild
    {
        public int? ArticleId { get; set; }
        public Article Article { get; set; }

        public int? AssortmentId { get; set; }
        public PromotionAssortment Assortment { get; set; }
    }
}