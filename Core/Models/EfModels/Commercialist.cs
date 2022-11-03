using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Partners;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Commercialist : CodebookCompanyBase
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(100)]
        public string Email { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(50)]
        public string Phone { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(50)]
        public string MobilePhone { get; set; }

        public IEnumerable<Partner> Partners { get; set; }
    }
}
