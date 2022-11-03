using System.Collections.Generic;
using Core.Models.Requests.Base;
using Core.Models.Requests.CustomerPrice;

namespace Core.Models.Requests.Partner
{
    public class PartnerCustomerPricesModifyRequest : BaseRequest
    {
        public int PartnerId { get; set; }

        public List<CustomerPriceUpdateRequest> CustomerPrices { get; set; }
    }
}
