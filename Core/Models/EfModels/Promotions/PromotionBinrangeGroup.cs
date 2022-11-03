using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionBinrangeGroup : PromotionChild
    {
        public int? RangeId { get; set; }
        public CardIdentificationNumberRange Range { get; set; }

        public int? CardCodeId { get; set; }
        public CardCode CardCode { get; set; }

        public int? CardDataSourceId { get; set; }
        public AppCode CardDataSource { get; set; }
    }
}
