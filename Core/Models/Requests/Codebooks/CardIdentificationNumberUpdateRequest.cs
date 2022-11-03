using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CardIdentificationNumberUpdateRequest : CardIdentificationNumberCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
