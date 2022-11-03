using System;
using Core.Models.EfModels.Codebooks;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class DocumentFilterRequest : BaseFilterRequest
    {
        public int? FiscalYearId { get; set; }
        public RangeFilter<int> Year { get; set; }
        public RangeFilter<int> Number { get; set; }
        public int? SiteId { get; set; }
        public int? CurrencyId { get; set; }
        public int? PartnerId { get; set; }
        public int? TypeId { get; set; }
        public int? StatusId { get; set; }

        public Guid? HeadDocumentId { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? HasHeadDocument { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? HasCloneDocument { get; set; }

        public string InvoiceNumber { get; set; }
        public string FiscalNumber { get; set; }

        public int? CardTypeId { get; set; }
        public string CardNumber { get; set; }

        public int? VehicleTypeId { get; set; }
        public string TruckRegistrationPlate { get; set; }

        public int? DeliveryPointId { get; set; }
        public int? DirectDeliveryPointId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public int? RealTypeId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public int? RealTypeKey { get; set; }

        public RangeFilter<DateOnly> Date { get; set; }
        public RangeFilter<DateOnly> DeliveryDate { get; set; }
        public RangeFilter<DateTime> ConfirmationDate { get; set; }
        public RangeFilter<DateOnly> PeriodFrom { get; set; }
        public RangeFilter<DateOnly> PeriodTo { get; set; }
    }
}
