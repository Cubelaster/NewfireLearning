using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CountryUpdateRequest : CountryCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
