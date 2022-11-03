using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Configs;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;
using Core.Models.EfModels.Promotions;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Company : DatabaseEntity<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required]
        public string Code { get; set; }

        public int? CountryId { get; set; }
        public Country Country { get; set; }

        public int? PostalCodeId { get; set; }
        public PostalCode PostalCode { get; set; }

        public IEnumerable<CompanyUser> Users { get; set; }
        public List<CompanyCurrency> CompanyCurrencies { get; set; }

        public IEnumerable<Currency> Currencies { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<PostalCode> PostalCodes { get; set; }
        public IEnumerable<DeliveryPoint> DeliveryPoints { get; set; }

        public IEnumerable<Commercialist> Commercialists { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
        public IEnumerable<ParticipantType> ParticipantTypes { get; set; }
        public IEnumerable<Partner> Partners { get; set; }
        public IEnumerable<PartnerType> PartnerTypes { get; set; }
        public IEnumerable<ParityTerm> ParityTerms { get; set; }
        public IEnumerable<PaymentTerm> PaymentTerms { get; set; }

        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<ArticleCategory> ArticleCategories { get; set; }
        public IEnumerable<ArticleType> ArticleTypes { get; set; }
        public IEnumerable<Assortment> Assortments { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }

        public IEnumerable<AnalysisType> AnalysisTypes { get; set; }
        public IEnumerable<Document> Documents { get; set; }
        public IEnumerable<DocumentItem> DocumentItems { get; set; }
        public IEnumerable<DependentCost> DependentCosts { get; set; }
        public IEnumerable<DocumentType> DocumentTypes { get; set; }
        public IEnumerable<AdditionalFuelNote> AdditionalFuelNotes { get; set; }
        public IEnumerable<AdditionalFuelNoteType> AdditionalFuelNoteTypes { get; set; }
        public IEnumerable<TransportInfo> TransportInfos { get; set; }

        public IEnumerable<DecimalPlacesSettings> DecimalPlacesSettings { get; set; }
        public IEnumerable<FeeType> FeeTypes { get; set; }
        public IEnumerable<FiscalYear> FiscalYears { get; set; }

        public IEnumerable<CustomerCreditLimit> CreditLimits { get; set; }
        public IEnumerable<CustomerPrice> CustomerPrices { get; set; }
        public IEnumerable<PurchasePrice> PurchasePrices { get; set; }
        public IEnumerable<SalesPrice> SalesPrices { get; set; }
        public IEnumerable<PriceCalculationRounding> SalesPriceCalculationRoundings { get; set; }

        public IEnumerable<SalesPriceGroup> SalesPriceGroups { get; set; }
        public IEnumerable<SalesPriceType> SalesPriceTypes { get; set; }
        public IEnumerable<Site> Sites { get; set; }
        public IEnumerable<SiteBrand> SiteBrands { get; set; }
        public IEnumerable<SiteContent> SiteContents { get; set; }
        public IEnumerable<SiteCategory> SiteCategories { get; set; }
        public IEnumerable<SiteFormat> SiteFormats { get; set; }
        public IEnumerable<SiteModel> SiteModels { get; set; }
        public IEnumerable<SiteRegion> SiteRegions { get; set; }
        public IEnumerable<SiteStatus> SiteStatuses { get; set; }
        public IEnumerable<SiteType> SiteTypes { get; set; }

        public IEnumerable<TaxGroup> TaxGroups { get; set; }
        public IEnumerable<TaxType> TaxTypes { get; set; }

        public IEnumerable<UnitOfMeasure> UnitsOfMeasure { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<VehicleCompartment> VehicleCompartments { get; set; }

        public IEnumerable<CardCode> CardCodes { get; set; }

        public IEnumerable<CardIdentificationNumberRange> CardIdentificationNumberRanges { get; set; }
        public IEnumerable<CardIdentificationNumber> CardIdentificationNumbers { get; set; }

        #region Config

        public IEnumerable<EntityGridColumnConfig> EntityGridColumnConfigs { get; set; }
        public IEnumerable<EntityReport> EntityReports { get; set; }
        public IEnumerable<StoredProcedureReport> StoredProcedureReports { get; set; }
        public IEnumerable<StoredProcedureReportParam> StoredProcedureReportParams { get; set; }


        #endregion Config

        public IEnumerable<PaymentMethod> PaymentMethods { get; set; }
        public IEnumerable<MarketingActionType> MarketingActionType { get; set; }

        public IEnumerable<Promotion> Promotions { get; set; }
        public IEnumerable<PromotionDiscount> PromotionDiscounts { get; set; }
        public IEnumerable<PromotionCondition> PromotionConditions { get; set; }
        public IEnumerable<PromotionNormative> PromotionNormatives { get; set; }
        public IEnumerable<PromotionBinrangeGroup> PromotionBinrangeGroups { get; set; }
        public IEnumerable<PromotionPayment> PromotionPayments { get; set; }
        public IEnumerable<PromotionSite> PromotionSites { get; set; }
        public IEnumerable<PromotionImage> PromotionImages { get; set; }
    }
}
