using Core.Enums;

namespace Core.Models.EfModels
{
    public class User
    //: IdentityUser<Guid>
    {
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DatabaseEntityStatus Status { get; set; }

        public Person UserDetails { get; set; }

        public List<UserRoles> UserRoles { get; set; }
        //public List<UserClaim> UserClaims { get; set; }

        public List<UserRenewToken> UserRenewTokens { get; set; }

        public List<CompanyUser> CompanyUsers { get; set; }
    }
}
