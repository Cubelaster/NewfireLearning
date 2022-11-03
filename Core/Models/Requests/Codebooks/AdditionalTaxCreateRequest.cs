using System.Collections.Generic;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AdditionalTaxCreateRequest : CodebookBaseCreateRequest
    {
        public List<AdditionalTaxValueCreateRequest> AdditionalTaxValues { get; set; }
    }
}
