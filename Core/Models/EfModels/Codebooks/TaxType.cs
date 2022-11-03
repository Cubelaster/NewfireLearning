using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Codebooks
{
    public class TaxType : CodebookCompanyBase
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<TaxGroup> TaxGroups { get; set; }

        public IEnumerable<ArticleTaxType> Articles { get; set; }
        public IEnumerable<PartnerTaxType> Partners { get; set; }
        public IEnumerable<DocumentItem> DocumentItems { get; set; }
        public IEnumerable<DependentCost> DependentCosts { get; set; }
    }
}
