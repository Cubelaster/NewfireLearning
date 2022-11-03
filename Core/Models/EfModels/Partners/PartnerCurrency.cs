using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Partners
{
    public class PartnerCurrency : DatabaseEntity<int>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
