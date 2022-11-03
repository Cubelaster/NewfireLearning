using System;

namespace Core.Models.Responses.Authorization
{
    public class LoginResponse
    {
        public string JwtToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
