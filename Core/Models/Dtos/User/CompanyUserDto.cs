using System;

namespace Core.Models.Dtos.User
{
    public class CompanyUserDto
    {
        public Guid UserId { get; set; }

        public int CompanyId { get; set; }
    }
}
