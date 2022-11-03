using System;
using System.Collections.Generic;
using Core.Models.Dtos.Document;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Partner;
using Core.Models.ViewModels.Site;

namespace Core.Models.ViewModels.Document
{
    public class DocumentDetailViewModel : DocumentGridViewModel
    {
        public string LocalSiteId { get; set; }
        public string LocalDocumentNumber { get; set; }

        public string OriginalDocumentNumber { get; set; }

        public PartnerBaseViewModel Partner { get; set; }
        public string PartnerName { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerPostalCode { get; set; }

        public int? ValueDays { get; set; }
        public DateOnly? ValueDate { get; set; }

        public DateOnly? PeriodFrom { get; set; }
        public DateOnly? PeriodTo { get; set; }

        public string InvoiceNumber { get; set; }
        public string FiscalNumber { get; set; }
        public int? ShiftNumber { get; set; }

        public CodebookBaseViewModel ParityTerm { get; set; }
        public CodebookBaseViewModel PrintType { get; set; }

        public AppCodeViewModel CardType { get; set; }
        public string CardNumber { get; set; }

        public bool? SendToPartner { get; set; }
        public PartnerBaseViewModel Transporter { get; set; }
        public AppCodeViewModel VehicleType { get; set; }
        public string TruckRegistrationPlate { get; set; }
        public string TrailerRegistrationPlate { get; set; }

        public SiteBaseViewModel DeliverySite { get; set; }
        public DeliveryPointViewModel DeliveryPoint { get; set; }
        public CodebookBaseViewModel DirectDeliveryPoint { get; set; }
        public string DeliveryNote { get; set; }
        public decimal? CompositionWeight { get; set; }

        public List<DocumentItemViewModel> Items { get; set; }
        public List<DocumentParticipantDto> Participants { get; set; }
        public List<DocumentVehicleDto> Vehicles { get; set; }
        public List<DocumentNoteDto> Notes { get; set; }
        public List<DocumentFuelAnalysisDto> DocumentFuelAnalyses { get; set; }
        public List<DependentCostViewModel> DependentCosts { get; set; }
        public List<AdditionalFuelNoteViewModel> AdditionalFuelNotes { get; set; }
        public List<TransportInfoViewModel> TransportInfos { get; set; }
        public List<DocumentPaymentViewModel> Payments { get; set; }
    }
}
