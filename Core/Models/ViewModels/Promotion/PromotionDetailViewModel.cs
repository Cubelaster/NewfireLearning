using System.Collections.Generic;
using Core.Models.Dtos.Promotions;

namespace Core.Models.ViewModels.Promotion
{
    public class PromotionDetailViewModel : PromotionViewModel
    {
        public IEnumerable<PromotionDiscountDto> Discounts { get; set; }
        public IEnumerable<PromotionConditionDto> Conditions { get; set; }
        public IEnumerable<PromotionNormativeDto> Normatives { get; set; }
        public IEnumerable<PromotionBinrangeGroupDto> BinrangeGroups { get; set; }
        public IEnumerable<PromotionSiteDto> Sites { get; set; }
        public IEnumerable<PromotionPaymentDto> Payments { get; set; }
        public IEnumerable<PromotionImageDto> Images { get; set; }
    }
}
