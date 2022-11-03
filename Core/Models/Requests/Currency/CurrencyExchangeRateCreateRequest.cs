using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Currency
{
    public class CurrencyExchangeRateCreateRequest : BaseRequest
    {
        public int CurrencyId { get; set; }
        public int CurrencyRefId { get; set; }

        public int CompanyId { get; set; }

        public DateOnly ValidOn { get; set; }
        public decimal Units { get; set; }

        public decimal BuyingRate { get; set; }
        public decimal MiddleRate { get; set; }
        public decimal SellingRate { get; set; }

        public int TypeId { get; set; }
    }
}
