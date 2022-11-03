using System;

namespace Core.Models.Responses.Security
{
    public class GenerateJwtTokenResponse
    {
        public string Token { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
