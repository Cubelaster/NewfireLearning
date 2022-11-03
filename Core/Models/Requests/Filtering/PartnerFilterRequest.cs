using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class PartnerFilterRequest : BaseFilterRequest
    {
        public string Code { get; set; }
        public string CodeExternal { get; set; }

        public string NameAdditional { get; set; }

        public int? CurrencyId { get; set; }

        public int? CommercialistId { get; set; }

        public string PibOib { get; set; }
        public string MBR { get; set; }
        public string VAT { get; set; }

        public int? SiteRegionId { get; set; }

        public int? PrintTypeId { get; set; }

        public RangeFilter<decimal> CreditLimitCustomer { get; set; }
        public int? PaymentTermsCustomerId { get; set; }

        public RangeFilter<decimal> CreditLimitSupplier { get; set; }
        public int? PaymentTermsSupplierId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public int? PartnerTypeId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public int? PartnerTypeAppCodeId { get; set; }
    }
}
