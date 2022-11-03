using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Codebooks
{
    public class DeliveryPoint : CodebookCompanyBase
    {
        public int PostalCodeId { get; set; }
        public PostalCode PostalCode { get; set; }

        public IEnumerable<CustomerPrice> CustomerPrices { get; set; }
        public IEnumerable<Document> Documents { get; set; }
    }
}
