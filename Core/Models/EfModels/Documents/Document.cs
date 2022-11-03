using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Documents
{
    public class Document : DatabaseEntity<Guid>
    {
        #region General

        public int FiscalYearId { get; set; }
        public FiscalYear FiscalYear { get; set; }

        public int Year { get; set; }

        public int Number { get; set; }

        /// <summary>
        /// Site is used on ALL document types except for ComprehensiveInvoice
        /// ComprehensiveInvoice is a special type of Document aggregating all the rest
        /// </summary>
        public int? SiteId { get; set; }
        public Site Site { get; set; }

        public int TypeId { get; set; }
        public DocumentType Type { get; set; }

        public int StatusId { get; set; }
        public DocumentStatus Status { get; set; }

        public DateOnly Date { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? CustomsExchangeRate { get; set; }

        #endregion General

        #region Specific per DocumentType

        public int? PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int? DeliverySiteId { get; set; }
        public Site DeliverySite { get; set; }
        public DateOnly? DeliveryDate { get; set; }

        public DateOnly? PeriodFrom { get; set; }
        public DateOnly? PeriodTo { get; set; }

        [StringLength(255)]
        public string PartnerName { get; set; }
        [StringLength(255)]
        public string PartnerAddress { get; set; }
        [StringLength(255)]
        public string PartnerPostalCode { get; set; }
        public int? ValueDays { get; set; }
        public DateOnly? ValueDate { get; set; }

        [StringLength(200)]
        public string DeliveryNote { get; set; }

        [StringLength(60)]
        public string LocalSiteId { get; set; }
        [StringLength(60)]
        public string LocalDocumentNumber { get; set; }

        [StringLength(60)]
        public string OriginalDocumentNumber { get; set; }

        [StringLength(60)]
        public string InvoiceNumber { get; set; }
        [StringLength(200)]
        public string FiscalNumber { get; set; }

        public int? ShiftNumber { get; set; }

        public int? ParityTermId { get; set; }
        public ParityTerm ParityTerm { get; set; }

        public int? PrintTypeId { get; set; }
        public PrintType PrintType { get; set; }

        public int? TransporterId { get; set; }
        public Partner Transporter { get; set; }

        public bool? SendToPartner { get; set; }
        public int? DeliveryPointId { get; set; }
        public DeliveryPoint DeliveryPoint { get; set; }
        public int? DirectDeliveryPointId { get; set; }
        public DirectDeliveryPoint DirectDeliveryPoint { get; set; }

        public decimal? CompositionWeight { get; set; }

        public int? CardTypeId { get; set; }
        public AppCode CardType { get; set; }
        [StringLength(60)]
        public string CardNumber { get; set; }

        public int? VehicleTypeId { get; set; }
        public AppCode VehicleType { get; set; }

        [StringLength(60)]
        public string TruckRegistrationPlate { get; set; }
        [StringLength(60)]
        public string TrailerRegistrationPlate { get; set; }

        #endregion Specific per DocumentType

        public List<DocumentItem> Items { get; set; }
        public List<DocumentParticipant> Participants { get; set; }
        public List<DocumentVehicle> Vehicles { get; set; }
        public List<DocumentNote> Notes { get; set; }
        public List<DependentCost> DependentCosts { get; set; }
        public List<AdditionalFuelNote> AdditionalFuelNotes { get; set; }
        public List<DocumentFuelAnalysis> DocumentFuelAnalyses { get; set; }
        public List<TransportInfo> TransportInfos { get; set; }
        public List<DocumentPayment> Payments { get; set; }

        #region Complex Relationships

        // This right here is how we handle Clones and Parent documents
        // Clones get created by cloning (Cancel or when creating ComprehensiveInvoice
        // Head document is currently only ComprehensiveInvoice
        // And in such case, HeadDocument contains other Documents as Items

        public Guid? HeadDocumentId { get; set; }
        public Document HeadDocument { get; set; }
        public List<Document> DocumentsAsItems { get; set; }

        public Guid? OriginalId { get; set; }
        public Document Original { get; set; }
        public List<Document> Clones { get; set; }

        #endregion Complex Relationships

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
