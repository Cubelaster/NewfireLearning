using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentPaymentUpdateRequest : DocumentPaymentCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
