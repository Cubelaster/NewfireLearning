using System.Collections.Generic;
using Core.Models.Dtos.Partner;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Partner
{
    public class PartnerDetailViewModel : PartnerGridViewModel
    {
        public decimal? CreditLimitCustomer { get; set; }
        public CodebookBaseViewModel PaymentTermsCustomer { get; set; }

        public decimal? CreditLimitSupplier { get; set; }
        public CodebookBaseViewModel PaymentTermsSupplier { get; set; }

        public List<PartnerCurrencyDto> Currencies { get; set; }
        public List<PartnerSiteDto> Sites { get; set; }
        public List<PartnerTaxTypeDto> TaxTypes { get; set; }
        public List<PartnerPartnerTypeDto> PartnerTypes { get; set; }
        public List<PartnerSalesPriceTypeDto> SalesPriceTypes { get; set; }
    }
}
