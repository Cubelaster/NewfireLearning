using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DocumentTypeUpdateRequest : DocumentTypeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
