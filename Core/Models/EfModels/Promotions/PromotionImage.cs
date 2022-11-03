using System.ComponentModel.DataAnnotations;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionImage : PromotionChild
    {
        [StringLength(100)]
        public string Title { get; set; }
        public int OrderNo { get; set; }
        public string Data { get; set; }
    }
}
