using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class AdditionalTaxValueViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public int AdditionalTaxId { get; set; }
        public int CurrencyId { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.AdditionalTaxValue;
        public string DisplayValue => $"{(AmountPercentage.HasValue ? AmountPercentage + '%' : AmountFixed)} {DateFrom}-{(DateTo.HasValue ? DateTo.ToString() : "")}";
    }
}
