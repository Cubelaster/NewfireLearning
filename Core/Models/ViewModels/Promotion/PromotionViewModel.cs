using System;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Promotion
{
    public class PromotionViewModel : PromotionBaseViewModel
    {

        public int? PromotionTypeId { get; set; }
        public AppCodeViewModel PromotionType { get; set; }

        public int? CombinationTypeId { get; set; }
        public AppCodeViewModel CombinationType { get; set; }

        public int? DisplayTypeId { get; set; }
        public AppCodeViewModel DisplayType { get; set; }

        public int MarketingActionTypeId { get; set; }
        public CodebookBaseViewModel MarketingActionType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public string Days { get; set; }

        public bool IsForForecourt { get; set; }
        public string MarketingMessage { get; set; }
        public int CodeLength { get; set; }
        public bool IsCombo { get; set; }
        public int ComboScale { get; set; }
        public decimal Price { get; set; }
        public bool IsBinRange { get; set; }
        public string Psp { get; set; }
        public int OrderNo { get; set; }
        public bool ShowOnPos { get; set; }
        public bool ShowOnCustomerDisplay { get; set; }

        public bool IsActive { get; set; }
    }
}
