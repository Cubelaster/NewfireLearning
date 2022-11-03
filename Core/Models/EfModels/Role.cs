//using System;
//using System.Collections.Generic;
//using Microsoft.AspNetCore.Identity;

//namespace Core.Models.EfModels
//{
//    public class Role : IdentityRole<Guid>
//    {
//        public int? CompanyId { get; set; }
//        public Company Company { get; set; }

//        public ICollection<UserRoles> UserRoles { get; set; }
//        public ICollection<RoleClaim> RoleClaims { get; set; }
//    }
//}
