using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.User
{
    public class UserCreateRequest : BaseRequest
    {
        [Required]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<int> CompanyIds { get; set; } = new List<int>();
        public List<Guid> RoleIds { get; set; } = new List<Guid>();

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Mobile { get; set; }
        public string Phone { get; set; }

        public string Oib { get; set; }
    }
}
