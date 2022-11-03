using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Article
{
    public class AssortmentCreateRequest : CodebookBaseCreateRequest
    {
        public new int? Code { get; set; }
    }
}
