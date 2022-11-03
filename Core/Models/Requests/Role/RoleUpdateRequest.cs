using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Role
{
    public class RoleUpdateRequest : RoleCreateRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
