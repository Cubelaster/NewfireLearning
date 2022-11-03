using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AdditionalTaxUpdateRequest : AdditionalTaxCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
        public new List<AdditionalTaxValueUpdateRequest> AdditionalTaxValues { get; set; }
    }
}
