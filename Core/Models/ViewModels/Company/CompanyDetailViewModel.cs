using System.Collections.Generic;
using Core.Models.Dtos.Company;

namespace Core.Models.ViewModels.Company
{
    public class CompanyDetailViewModel : CompanyBaseViewModel
    {
        public int? CountryId { get; set; }
        public int? PostalCodeId { get; set; }

        public List<CompanyCurrencyDto> CompanyCurrencies { get; set; }
    }
}
