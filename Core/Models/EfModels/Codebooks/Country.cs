using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

//https://www.nationsonline.org/oneworld/country_code_list.htm
namespace Core.Models.EfModels.Codebooks
{
    public class Country : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(2), Required]
        public string Code { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<PostalCode> PostalCodes { get; set; }
        public IEnumerable<TaxType> TaxTypes { get; set; }
    }
}
