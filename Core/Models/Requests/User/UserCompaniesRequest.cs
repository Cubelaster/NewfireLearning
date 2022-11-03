using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.User
{
    public class UserCompaniesRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public List<int> CompanyIds { get; set; }
    }
}
