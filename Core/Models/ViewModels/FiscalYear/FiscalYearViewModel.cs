using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.FiscalYear
{
    public class FiscalYearViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public bool IsLocked { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.FiscalYear;
        public string DisplayValue => Year.ToString();
    }
}
