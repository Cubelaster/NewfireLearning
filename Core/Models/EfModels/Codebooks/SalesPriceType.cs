using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Codebooks
{
    public class SalesPriceType : CodebookCompanyBase
    {
        public IEnumerable<SalesPrice> SalesPrices { get; set; }
        public IEnumerable<SiteSalesPriceType> SiteSalesPriceTypes { get; set; }
        public IEnumerable<PartnerSalesPriceType> PartnerSalesPriceTypes { get; set; }
    }
}
