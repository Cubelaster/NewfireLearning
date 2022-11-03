using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Authorization
{
    public class RegisterRequest : BaseRequest
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> CompanyIds { get; set; }
        public List<string> Roles { get; set; }
    }
}
