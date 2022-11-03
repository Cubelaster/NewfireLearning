using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.User
{
    public class UserRolesRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public int? CompanyId { get; set; }
        public List<Guid> RoleIds { get; set; }
    }
}
