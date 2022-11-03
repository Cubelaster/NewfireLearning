using System;

namespace Core.Models.Responses.Authorization
{
    public class RegisterResponse
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordResetToken { get; set; }
        public string EmailConfirmToken { get; set; }
    }
}
