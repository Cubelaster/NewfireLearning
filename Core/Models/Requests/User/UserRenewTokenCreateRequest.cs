using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.User
{
    public class UserRenewTokenCreateRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
