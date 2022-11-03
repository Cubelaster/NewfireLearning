using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AdditionalTaxValueUpdateRequest : AdditionalTaxValueCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
