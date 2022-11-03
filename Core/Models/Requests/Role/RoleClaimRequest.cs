using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Role
{
    public class RoleClaimRequest : BaseRequest
    {
        public Guid RoleId { get; set; }
        public List<int> AppClaimIds { get; set; }
    }
}
