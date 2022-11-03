using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class CurrencyExchangeRateBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateOnly ValidOn { get; set; }
        public decimal Units { get; set; }
        public decimal BuyingRate { get; set; }
        public decimal MiddleRate { get; set; }
        public decimal SellingRate { get; set; }

        public int TypeId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.CurrencyExchangeRate;
        public string DisplayValue => $"{MiddleRate} - {ValidOn}";
    }
}
