using System;

namespace Core.Models.Requests.Authorization
{
    public class RefreshTokenRequest
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public bool RememberMe { get; set; }
    }
}
