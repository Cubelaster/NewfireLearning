using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class TaxTypeUpdateRequest : TaxTypeCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }

        public new List<TaxGroupUpdateRequest> TaxGroups { get; set; }
    }
}
