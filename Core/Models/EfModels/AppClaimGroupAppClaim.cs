using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class AppClaimGroupAppClaim : DatabaseEntity<int>
    {
        public int AppClaimGroupId { get; set; }
        public AppClaimGroup AppClaimGroup { get; set; }

        public int AppClaimId { get; set; }
        public AppClaim AppClaim { get; set; }
    }
}
