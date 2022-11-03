using System.Collections.Generic;
using Core.Models.Dtos.Promotions;

namespace Core.Models.ViewModels.Promotion
{
    public class PromotionAssortmentDetailViewModel : PromotionAssortmentViewModel
    {
        public IEnumerable<PromotionAssortmentArticleDto> Articles { get; set; }
    }
}
