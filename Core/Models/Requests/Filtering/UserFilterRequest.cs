using System;
using ReFilter.Attributes;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class UserFilterRequest : IReFilterRequest
    {
        public string Email { get; set; }
        public string UserName { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public int? CompanyId { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public Guid? RoleId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string FirstName { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string MiddleName { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string LastName { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string Mobile { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string Phone { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public string Oib { get; set; }

        public bool? EmailConfirmed { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public bool? IsActive { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? IsSuperAdmin { get; set; }
    }
}
