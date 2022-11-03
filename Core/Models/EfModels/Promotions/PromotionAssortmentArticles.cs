using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionAssortmentArticle : DatabaseEntity<int>
    {
        public bool IsActive { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int AssortmentId { get; set; }
        public PromotionAssortment Assortment { get; set; }
    }
}
