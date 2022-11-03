using Core.Models.ViewModels.Article;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionAssortmentArticleDto
    {
        public int? Id { get; set; }
        public int AssortmentId { get; set; }
        public int ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public bool IsActive { get; set; }
    }
}
