using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class ArticleUpdateRequest : ArticleCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
