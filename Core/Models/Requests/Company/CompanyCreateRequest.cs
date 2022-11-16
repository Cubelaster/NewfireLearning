using Core.Models.Requests.Base;

namespace Core.Models.Requests.Company
{
    public class CompanyCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public int? PostalCodeId { get; set; }
    }
}
