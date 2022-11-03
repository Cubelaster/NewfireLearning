using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;
using Core.Models.ViewModels.AppClaim;

namespace Core.Models.Requests.Role
{
    public class RoleCreateRequest : BaseRequest
    {
        public int? CompanyId { get; set; }
        [Required]
        public string Name { get; set; }

        public List<ClaimTreeViewModel> AppClaims { get; set; }
        public List<Guid> UserIds { get; set; }
    }
}
