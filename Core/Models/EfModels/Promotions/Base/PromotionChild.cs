namespace Core.Models.EfModels.Promotions
{
    public class PromotionChild : PromotionDatabaseEntity
    {
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
