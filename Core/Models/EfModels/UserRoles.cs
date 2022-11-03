namespace Core.Models.EfModels
{
    public class UserRoles
    //: IdentityUserRole<Guid>
    {
        public virtual User User { get; set; }
        //public virtual Role Role { get; set; }
    }
}
