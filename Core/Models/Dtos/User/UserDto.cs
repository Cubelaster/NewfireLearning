using System;
using System.Collections.Generic;
using System.Security.Claims;
using Core.Models.Dtos.Person;
using Core.Models.ViewModels.Role;

namespace Core.Models.Dtos.User
{
    public class UserDto
    {
        public Guid? Id { get; set; }
        public int? UserDetailsId { get; set; }
        public PersonDto UserDetails { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public List<Claim> Claims { get; set; }
        public List<RoleViewModel> UserRoles { get; set; }
        public List<CompanyUserDto> CompanyUsers { get; set; }

        public bool IsSuperAdmin { get; set; }
    }
}
