using System;
using System.Collections.Generic;
using System.Linq;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Partner;
using Core.Models.ViewModels.Site;

namespace Core.Models.ViewModels.Document
{
    public class DocumentForComprehensiveGridViewModel : DocumentGridViewModel
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

        public List<DocumentItemViewModel> Items { get; set; }

        public decimal SalesPriceNetTotal => Items.Sum(e => e.SalesPriceNetTotal ?? 0);
        public decimal SalesPriceDiscountAmountTotal => Items.Sum(e => e.SalesPriceDiscountAmountTotal ?? 0);
        public decimal SalesPriceNetDiscountTotal => Items.Sum(e => e.SalesPriceNetDiscountTotal ?? 0);
        public decimal SalesPriceExciseDutyTotal => Items.Sum(e => e.SalesPriceExciseDutyTotal ?? 0);
        public decimal SalesPriceNetExciseDutyTotal => Items.Sum(e => e.SalesPriceNetExciseDutyTotal ?? 0);
        public decimal SalesPriceTaxAmountTotal => Items.Sum(e => e.SalesPriceTaxAmountTotal ?? 0);
        public decimal SalesPricePackageRefundFeeTotal => Items.Sum(e => e.SalesPricePackageRefundFeeTotal ?? 0);
        public decimal SalesPriceTotal => Items.Sum(e => e.SalesPriceTotal ?? 0);

        public decimal MarginAmountTotal => Items.Sum(e => e.MarginAmount ?? 0);
    }
}
