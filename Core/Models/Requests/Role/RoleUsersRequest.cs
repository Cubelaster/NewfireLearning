using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Role
{
    public class RoleUsersRequest : BaseRequest
    {
        public Guid RoleId { get; set; }
        public List<Guid> UserIds { get; set; }
    }
}
