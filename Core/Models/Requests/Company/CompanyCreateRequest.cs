using System.Collections.Generic;
using Core.Models.Dtos.Company;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Company
{
    public class CompanyCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public int? PostalCodeId { get; set; }

        public List<CompanyCurrencyDto> CompanyCurrencies { get; set; }
    }
}
