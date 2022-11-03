using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Codebooks
{
    public class CountryCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }

        [Required]
        public int? CompanyId { get; set; }

        public Translations Translations { get; set; }
    }
}
