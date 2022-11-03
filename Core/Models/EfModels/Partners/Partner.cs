using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.EntityConnectors;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Partners
{
    public class Partner : DatabaseEntity<int>
    {
        [ReFilterProperty]
        [Required, StringLength(50)]
        public string Code { get; set; }

        [ReFilterProperty]
        [StringLength(20)]
        public string PibOib { get; set; }

        [ReFilterProperty]
        [StringLength(20)]
        public string MBR { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(255)]
        public string NameAdditional { get; set; }

        [ReFilterProperty]
        [StringLength(50)]
        public string CodeExternal { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int? CommercialistId { get; set; }
        public Commercialist Commercialist { get; set; }

        public int? SiteRegionId { get; set; }
        public SiteRegion SiteRegion { get; set; }

        public int? PrintTypeId { get; set; }
        public PrintType PrintType { get; set; }

        public decimal? CreditLimitCustomer { get; set; }
        public int? PaymentTermsCustomerId { get; set; }
        public PaymentTerm PaymentTermsCustomer { get; set; }

        public decimal? CreditLimitSupplier { get; set; }
        public int? PaymentTermsSupplierId { get; set; }
        public PaymentTerm PaymentTermsSupplier { get; set; }

        public List<PartnerPartnerType> PartnerTypes { get; set; }
        public List<PartnerTaxType> TaxTypes { get; set; }
        public List<PartnerSite> Sites { get; set; }
        public List<PurchasePrice> PurchasePrices { get; set; }
        public List<PartnerCurrency> Currencies { get; set; }
        public List<CustomerPrice> CustomerPrices { get; set; }
        public List<CustomerCreditLimit> CreditLimits { get; set; }
        public List<PartnerSalesPriceType> SalesPriceTypes { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public IEnumerable<Document> Documents { get; set; }
        public IEnumerable<DependentCost> DependentCosts { get; set; }
        public IEnumerable<Document> TransporterDocuments { get; set; }
        public IEnumerable<DocumentPayment> DocumentPayments { get; set; }

        [NotMapped]
        public IEnumerable<EntityContact> Contacts { get; set; }
        [NotMapped]
        public IEnumerable<EntityAddress> Addresses { get; set; }
        [NotMapped]
        public IEnumerable<EntityNote> Notes { get; set; }
    }
}
