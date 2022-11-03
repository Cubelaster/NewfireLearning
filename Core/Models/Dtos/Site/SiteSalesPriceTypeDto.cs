using System;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Site
{
    public class SiteSalesPriceTypeDto
    {
        public int? Id { get; set; }
        public int SiteId { get; set; }
        public int SalesPriceTypeId { get; set; }
        public CodebookBaseViewModel SalesPriceType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
