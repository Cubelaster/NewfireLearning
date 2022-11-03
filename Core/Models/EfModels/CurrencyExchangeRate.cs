using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    /// <summary>
    /// https://www.hnb.hr/hnb-api
    /// This should be the only valid reference
    /// </summary>
    public class CurrencyExchangeRate : DatabaseEntity<int>
    {
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public int CurrencyRefId { get; set; }
        public Currency CurrencyRef { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public DateOnly ValidOn { get; set; }

        public decimal Units { get; set; }

        public decimal BuyingRate { get; set; }
        public decimal MiddleRate { get; set; }
        public decimal SellingRate { get; set; }

        public int TypeId { get; set; }
        public AppCode Type { get; set; }
    }
}
