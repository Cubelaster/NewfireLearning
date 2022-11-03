namespace Core.Models.EfModels
{
    public class RoleClaim
    //: IdentityRoleClaim<Guid>
    {
        public int AppClaimId { get; set; }
        public virtual AppClaim AppClaim { get; set; }

        //public virtual Role Role { get; set; }
    }
}
