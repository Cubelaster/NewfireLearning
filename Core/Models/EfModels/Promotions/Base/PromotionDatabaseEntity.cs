using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionDatabaseEntity : DatabaseEntity<int>
    {
        public bool IsActive { get; set; }
    }
}
