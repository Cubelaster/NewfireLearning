using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    // Not currently used but it might be later on
    // This one is important when we want to move away from current refresh token
    // and use something more like Identity 
    public class UserRenewToken : DatabaseEntity<int>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Token { get; set; }
        public DateTime ValidUntil { get; set; }

        public DateTime? RevokedOn { get; set; }
        public string RevokedById { get; set; }

        public string ReplacedByToken { get; set; }

        public bool IsExpired => DateTime.UtcNow >= ValidUntil;
        public bool IsRevoked => !RevokedOn.HasValue;
        public bool IsActive => !IsExpired && !IsRevoked;
    }
}
