namespace Core.Enums
{
    public enum EntityType
    {
        AppClaim = 1,
        Role = 2,
        Company = 3,
        User = 4,
        Site = 5,
        Commercialist = 6,
        Partner = 7,
        AppClaimGroup = 8,
        Article = 9,
        Assortment = 10,
        Barcode = 11,
        PurchasePrice = 12,
        SalesPrice = 13,
        PriceCalculationRounding = 14,
        DecimalPlacesSettings = 15,
        CustomerPrice = 16,
        Vehicle = 17,
        Participant = 18,
        Document = 19,
        DocumentItem = 20,
        FiscalYear = 21,
        Recipe = 22,
        DependentCost = 23,
        AdditionalFuelNote = 24,
        TransportInfo = 25,
        DocumentItemAdditionalTaxValue = 26,
        DocumentPayment = 27,
        CustomerCreditLimit = 28,
        StoredProcedureReport = 29,
        StoredProcedureReportParam = 30,

        // Zero because any default int is 0
        // Better to get Undefined accidentally than some valid one
        Undefined = 0,

        #region Codebooks

        Country = 100,
        Currency = 101,
        CurrencyExchangeRate = 102,
        TaxType = 103,
        SiteRegion = 104,
        SiteFormat = 105,
        SiteStatus = 106,
        SiteType = 107,
        SiteCategory = 108,
        SiteBrand = 109,
        SiteModel = 110,
        PostalCode = 111,
        SiteContent = 112,
        PaymentTerm = 113,
        TaxGroup = 114,
        UnitOfMeasure = 115,
        ArticleCategory = 116,
        ArticleType = 117,
        PartnerType = 118,
        PrintType = 119,
        SalesPriceGroup = 120,
        SalesPriceType = 121,
        ParityTerm = 122,
        DeliveryPoint = 123,
        VehicleCompartment = 124,
        FeeType = 125,
        DirectDeliveryPoint = 126,
        CardCode = 127,
        CardIdentificationNumberRange = 128,
        CardIdentificationNumber = 129,
        PaymentMethod = 130,
        MarketingActionType = 131,
        AdditionalFuelNoteType = 132,
        AnalysisType = 133,
        AdditionalTax = 134,
        AdditionalTaxValue = 135,
        CardType = 136,

        #endregion Codebooks

        #region Promotions

        Promotion = 700,
        PromotionDiscount = 701,
        PromotionCondition = 702,
        PromotionNormative = 703,
        PromotionBinRange = 704,
        PromotionPayment = 705,
        PromotionSite = 706,
        PromotionImage = 707,
        PromotionAssortment = 708,
        PromotionAssortmentArticle = 709,

        #endregion Promotions

        #region EntityConnectors

        EntityAddress = 300,
        EntityContact = 301,
        EntityExternalCode = 302,
        EntityNote = 303,

        #endregion EntityConnectors

        #region AppCodes

        AppCode = 500,
        AddressType = 501,
        ContactType = 502,
        ExternalCodeType = 503,
        NoteType = 504,
        PriceCalculationRoundingType = 505, // S crtom
        ParticipantType = 506,
        DocumentType = 507,
        DocumentStatus = 508,
        CardDataSource = 509,
        PaymentGroup = 510,
        PromotionType = 511,
        PromotionCombinationType = 512,
        PromotionDisplayType = 513,
        WarehouseType = 514,

        #endregion AppCodes

        #region Config

        EntityGridColumnConfig = 600,
        EntityReport = 601,

        #endregion Config

        #region Audit

        ApplicationActionDefinition = 800,
        ApplicationAction = 801,
        AuditLog = 802

        #endregion Audit        
    }
}