using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionAssortment : CodebookCompanyBase
    {
        public bool IsActive { get; set; }

        public List<PromotionAssortmentArticle> Articles { get; set; }


        public IEnumerable<PromotionDiscount> Discounts { get; set; }
        public IEnumerable<PromotionCondition> Conditions { get; set; }
        public IEnumerable<PromotionNormative> Normatives { get; set; }
    }
}
