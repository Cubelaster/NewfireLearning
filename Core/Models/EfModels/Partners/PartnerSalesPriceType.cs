using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Partners
{
    public class PartnerSalesPriceType : DatabaseEntity<int>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int SalesPriceTypeId { get; set; }
        public SalesPriceType SalesPriceType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
