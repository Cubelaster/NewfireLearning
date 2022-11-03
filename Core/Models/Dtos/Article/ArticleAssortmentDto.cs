using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Article
{
    public class ArticleAssortmentDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int AssortmentId { get; set; }
        public CodebookBaseViewModel? Assortment { get; set; }
    }
}
