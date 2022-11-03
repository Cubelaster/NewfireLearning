using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class TransportInfoUpdateRequest : TransportInfoCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
