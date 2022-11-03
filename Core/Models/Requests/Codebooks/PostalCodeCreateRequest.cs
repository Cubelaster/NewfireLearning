using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Codebooks
{
    public class PostalCodeCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public int? CompanyId { get; set; }

        public Translations Translations { get; set; }
    }
}
