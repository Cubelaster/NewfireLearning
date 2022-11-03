using Core.Models.Requests.Base;

namespace Core.Models.Requests.Authorization
{
    public class PasswordResetRequest : BaseRequest
    {
        public string Email { get; set; }
        public string PasswordResetToken { get; set; }
        public string ConfirmAccountToken { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
    }
}
