namespace Core.Models.Dtos.User.UserManagement
{
    public class AccountNotificationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string FormUrl { get; set; }
        public string EmailConfirmToken { get; set; }
        public string PasswordConfirmToken { get; set; }
    }
}
