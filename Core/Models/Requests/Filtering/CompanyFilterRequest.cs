using System.Collections.Generic;
using ReFilter.Attributes;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class CompanyFilterRequest : IReFilterRequest
    {
        [ReFilterProperty(HasSpecialFilter = true)]
        public string Name { get; set; }
        public string Code { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> CountryIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> CurrencyIds { get; set; }
    }
}
