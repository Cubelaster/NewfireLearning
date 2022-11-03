using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks.ArticleCategory
{
    public class ArticleCategoryUpdateRequest : ArticleCategoryCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }

        public new List<ArticleCategoryUpdateRequest> Children { get; set; }
    }
}
