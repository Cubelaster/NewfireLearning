using System.Collections.Generic;
using Core.Models.Dtos.Promotions;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Promotions
{
    public class PromotionAssortmentCreateRequest : CodebookBaseCreateRequest
    {
        public bool IsActive { get; set; }
        public List<PromotionAssortmentArticleDto> Articles { get; set; }
    }
}
