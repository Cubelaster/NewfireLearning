using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Document
{
    public class DocumentItemAdditionalTaxValueViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public Guid DocumentItemId { get; set; }

        public int AdditionalTaxId { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.DocumentItemAdditionalTaxValue;
        public string DisplayValue => null;
    }
}
