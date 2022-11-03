using System;
using System.Collections.Generic;
using Core.Models.Dtos.Promotions;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Promotions
{
    public class PromotionCreateRequest : BaseRequest
    {
        public string Code { get; set; }
        public Translations Translations { get; set; }
        public int CompanyId { get; set; }

        public int PromotionTypeId { get; set; }
        public int CombinationTypeId { get; set; }
        public int DisplayTypeId { get; set; }
        public int MarketingActionTypeId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public string Days { get; set; }
        public bool IsActive { get; set; }

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

        public IEnumerable<PromotionDiscountDto> Discounts { get; set; }
        public IEnumerable<PromotionConditionDto> Conditions { get; set; }
        public IEnumerable<PromotionNormativeDto> Normatives { get; set; }
        public IEnumerable<PromotionBinrangeGroupDto> BinrangeGroups { get; set; }
        public IEnumerable<PromotionSiteDto> Sites { get; set; }
        public IEnumerable<PromotionPaymentDto> Payments { get; set; }
        public IEnumerable<PromotionImageDto> Images { get; set; }
    }
}
