using System.Collections.Generic;
using Core.Models.Requests.Base;
using Core.Models.Requests.CustomerCreditLimit;

namespace Core.Models.Requests.Partner
{
    public class PartnerCustomerCreditLimitModifyRequest : BaseRequest
    {
        public int PartnerId { get; set; }

        public List<CustomerCreditLimitUpdateRequest> CreditLimits { get; set; }
    }
}
