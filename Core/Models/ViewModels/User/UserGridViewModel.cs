using System.Collections.Generic;
using Core.Models.ViewModels.Role;

namespace Core.Models.ViewModels.User
{
    public class UserGridViewModel : UserBaseViewModel
    {
        public string MiddleName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }

        public string Oib { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<RoleViewModel> Roles { get; set; }
    }
}
