using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class SiteSalesPriceType : DatabaseEntity<int>
    {
        public int SiteId { get; set; }
        public Site Site { get; set; }

        public int SalesPriceTypeId { get; set; }
        public SalesPriceType SalesPriceType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
