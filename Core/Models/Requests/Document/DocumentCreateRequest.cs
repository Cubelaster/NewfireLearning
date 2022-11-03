using System;
using System.Collections.Generic;
using Core.Models.Dtos.Document;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentCreateRequest : BaseRequest
    {
        public Guid? HeadDocumentId { get; set; }
        public Guid? OriginalId { get; set; }

        public int? SiteId { get; set; }

        public int? Number { get; set; }

        public int FiscalYearId { get; set; }
        public int Year { get; set; }

        public int TypeId { get; set; }

        public int StatusId { get; set; }

        public string LocalSiteId { get; set; }
        public string LocalDocumentNumber { get; set; }
        public string OriginalDocumentNumber { get; set; }

        public DateOnly Date { get; set; }
        public DateOnly? DeliveryDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public DateOnly? PeriodFrom { get; set; }
        public DateOnly? PeriodTo { get; set; }

        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? CustomsExchangeRate { get; set; }

        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerPostalCode { get; set; }
        public bool? SendToPartner { get; set; }

        public int? ValueDays { get; set; }
        public DateOnly? ValueDate { get; set; }

        public string InvoiceNumber { get; set; }
        public string FiscalNumber { get; set; }
        public int? ShiftNumber { get; set; }

        public int? ParityTermId { get; set; }
        public int? PrintTypeId { get; set; }

        public int? CardTypeId { get; set; }
        public string CardNumber { get; set; }

        public int? TransporterId { get; set; }
        public int? DeliverySiteId { get; set; }
        public string DeliveryNote { get; set; }
        public int? DeliveryPointId { get; set; }
        public int? DirectDeliveryPointId { get; set; }
        public int? VehicleTypeId { get; set; }
        public decimal? CompositionWeight { get; set; }
        public string TruckRegistrationPlate { get; set; }
        public string TrailerRegistrationPlate { get; set; }

        public virtual List<DocumentCreateRequest> DocumentsAsItems { get; set; }
        public virtual List<DocumentItemCreateRequest> Items { get; set; }
        public virtual List<DependentCostCreateRequest> DependentCosts { get; set; }
        public List<DocumentParticipantDto> Participants { get; set; }
        public List<DocumentVehicleDto> Vehicles { get; set; }
        public List<DocumentNoteDto> Notes { get; set; }
        public List<DocumentFuelAnalysisDto> DocumentFuelAnalyses { get; set; }
        public virtual List<AdditionalFuelNoteCreateRequest> AdditionalFuelNotes { get; set; }
        public virtual List<TransportInfoCreateRequest> TransportInfos { get; set; }
        public virtual List<DocumentPaymentCreateRequest> Payments { get; set; }

        public int CompanyId { get; set; }
    }
}
