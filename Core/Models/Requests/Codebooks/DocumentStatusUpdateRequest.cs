using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DocumentStatusUpdateRequest : DocumentStatusCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
