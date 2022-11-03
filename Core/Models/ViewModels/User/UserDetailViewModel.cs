using System.Collections.Generic;
using Core.Models.ViewModels.Company;

namespace Core.Models.ViewModels.User
{
    public class UserDetailViewModel : UserGridViewModel
    {
        public bool EmailConfirmed { get; set; }

        public IEnumerable<CompanyBaseViewModel> Companies { get; set; }
    }
}
