using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.Dtos.EntityConnectors;
using Core.Models.Dtos.Partner;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Partner
{
    public class PartnerCreateRequest : BaseRequest
    {
        public string Code { get; set; }
        public string CodeExternal { get; set; }

        public string Name { get; set; }
        public string NameAdditional { get; set; }

        [Required]
        public int? CompanyId { get; set; }

        [Required]
        public int? CurrencyId { get; set; }

        public string PibOib { get; set; }
        public string MBR { get; set; }
        public string VAT { get; set; }
        public DateTime? DateFrom { get; set; }

        public int? CommercialistId { get; set; }
        public int? PrintTypeId { get; set; }
        public int? SiteRegionId { get; set; }

        public decimal? CreditLimitCustomer { get; set; }
        public int? PaymentTermsCustomerId { get; set; }

        public decimal? CreditLimitSupplier { get; set; }
        public int? PaymentTermsSupplierId { get; set; }

        public List<PartnerSiteDto> Sites { get; set; }
        public List<PartnerTaxTypeDto> TaxTypes { get; set; }
        public List<PartnerPartnerTypeDto> PartnerTypes { get; set; }
        public List<PartnerCurrencyDto> Currencies { get; set; }
        public List<PartnerSalesPriceTypeDto> SalesPriceTypes { get; set; }

        public List<EntityAddressDto> Addresses { get; set; }
        public List<EntityContactDto> Contacts { get; set; }
        public List<EntityNoteDto> Notes { get; set; }
    }
}
