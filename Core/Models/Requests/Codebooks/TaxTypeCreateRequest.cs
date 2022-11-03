using System.Collections.Generic;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class TaxTypeCreateRequest : CodebookBaseCreateRequest
    {
        public int CountryId { get; set; }

        public List<TaxGroupCreateRequest> TaxGroups { get; set; }
    }
}
