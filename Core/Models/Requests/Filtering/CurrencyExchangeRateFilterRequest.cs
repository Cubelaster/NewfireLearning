using System;
using System.Collections.Generic;
using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class CurrencyExchangeRateFilterRequest : IReFilterRequest
    {
        public int? CurrencyId { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> CurrencyIds { get; set; }

        public int? CurrencyRefId { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> CurrencyRefIds { get; set; }

        public int? CompanyId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public DateOnly? ValidOn { get; set; }

        public RangeFilter<decimal> Units { get; set; }

        public RangeFilter<decimal> BuyingRate { get; set; }
        public RangeFilter<decimal> MiddleRate { get; set; }
        public RangeFilter<decimal> SellingRate { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? OnlyCurrent { get; set; }

        public int? TypeId { get; set; }
    }
}
