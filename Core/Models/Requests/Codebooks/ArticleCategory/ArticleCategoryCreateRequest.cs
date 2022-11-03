using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks.ArticleCategory
{
    public class ArticleCategoryCreateRequest : CodebookBaseCreateRequest
    {
        public int? ParentId { get; set; }

        public List<ArticleCategoryCreateRequest> Children { get; set; }
    }
}
