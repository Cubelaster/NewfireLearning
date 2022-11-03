using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class TaxGroupViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public decimal TaxPercentage { get; set; }
        public bool SpecialTaxPercentage { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int TaxTypeId { get; set; }
        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.TaxGroup;
        public string DisplayValue => $"{TaxPercentage}% {DateFrom}-{(DateTo.HasValue ? DateTo.ToString() : "")}";
    }
}
