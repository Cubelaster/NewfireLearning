using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class SalesPriceGroup : CodebookCompanyBase
    {
        public IEnumerable<SalesPrice> SalesPrices { get; set; }
    }
}
