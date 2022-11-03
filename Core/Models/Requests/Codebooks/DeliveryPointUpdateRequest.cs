using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DeliveryPointUpdateRequest : DeliveryPointCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
