using System;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Partner
{
    public class PartnerSalesPriceTypeDto
    {
        public int? Id { get; set; }
        public int PartnerId { get; set; }
        public int SalesPriceTypeId { get; set; }
        public CodebookBaseViewModel SalesPriceType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}