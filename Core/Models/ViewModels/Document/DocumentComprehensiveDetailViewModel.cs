using System;
using System.Collections.Generic;
using Core.Models.Dtos.Document;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Partner;
using Core.Models.ViewModels.Site;

namespace Core.Models.ViewModels.Document
{
    /// <summary>
    /// Pretty much a split from DocumentDetails simply because generic DocumentDetails 
    /// Should not even try to load DocumentsAsItems
    /// </summary>
    public class DocumentComprehensiveDetailViewModel : DocumentGridViewModel
    {
        public string LocalSiteId { get; set; }
        public string LocalDocumentNumber { get; set; }

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

        public List<DocumentForComprehensiveGridViewModel> DocumentsAsItems { get; set; }
        public List<DocumentNoteDto> Notes { get; set; }
    }
}
