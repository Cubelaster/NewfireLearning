namespace Core.Models.Dtos.Promotions
{
    public class PromotionBaseDto
    {
        public int? Id { get; set; }
        public int PromotionId { get; set; }
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }
    }
}
