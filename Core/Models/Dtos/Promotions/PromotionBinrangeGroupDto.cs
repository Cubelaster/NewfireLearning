using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionBinrangeGroupDto : PromotionBaseDto
    {
        public int? RangeId { get; set; }
        public CodebookBaseViewModel Range { get; set; }
        public int? CardCodeId { get; set; }
        public CodebookBaseViewModel CardCode { get; set; }
        public int? CardDataSourceId { get; set; }
        public AppCodeViewModel CardDataSource { get; set; }
    }
}
