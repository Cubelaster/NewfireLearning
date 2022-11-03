using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Authorization
{
    public class RoleModificationRequest : BaseRequest
    {
        [Required]
        public int? CompanyId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid RoleId { get; set; }
    }
}
