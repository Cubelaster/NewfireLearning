using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.Utility;

namespace Core.Models.EfModels
{
    public class AppClaim : DatabaseEntityTranslated<int>
    {
        [StringLength(255), Required]
        public string Type { get; set; }
        [StringLength(255), Required]
        public string Action { get; set; }
        public Translations Allows { get; set; }
        public Translations Description { get; set; }

        public IEnumerable<AppClaimGroupAppClaim> AppClaimGroups { get; set; }
    }
}
