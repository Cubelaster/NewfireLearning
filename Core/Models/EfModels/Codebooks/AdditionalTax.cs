using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class AdditionalTax : CodebookCompanyBase
    {
        public List<AdditionalTaxValue> AdditionalTaxValues { get; set; }

        public IEnumerable<ArticleAdditionalTax> ArticleAdditionalTaxes { get; set; }
        public IEnumerable<DocumentItemAdditionalTaxValue> DocumentItemAdditionalTaxValues { get; set; }
    }
}
