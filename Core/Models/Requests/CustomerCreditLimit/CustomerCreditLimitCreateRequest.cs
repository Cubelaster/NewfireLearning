using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.CustomerCreditLimit
{
    public class CustomerCreditLimitCreateRequest : BaseRequest
    {
        public int PartnerId { get; set; }

        public decimal Amount { get; set; }
        public bool IsAdditional { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public string Note { get; set; }

        public int CompanyId { get; set; }
    }
}
