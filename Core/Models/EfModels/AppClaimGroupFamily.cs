using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class AppClaimGroupFamily : DatabaseEntity<int>
    {
        public int ParentId { get; set; }
        public AppClaimGroup Parent { get; set; }

        public AppClaimGroup Child { get; set; }
        public int ChildId { get; set; }
    }
}
