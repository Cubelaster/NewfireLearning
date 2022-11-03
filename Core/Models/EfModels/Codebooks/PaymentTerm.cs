using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Codebooks
{
    public class PaymentTerm : CodebookCompanyBase 
    { 
        public IEnumerable<Partner> Customers { get; set; }
        public IEnumerable<Partner> Suppliers { get; set; }
        public IEnumerable<CustomerPrice> CustomerPrices { get; set; }
    }
}
