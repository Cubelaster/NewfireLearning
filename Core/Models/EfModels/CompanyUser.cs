using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class CompanyUser : DatabaseEntity<int>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
