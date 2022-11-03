using System.Collections.Generic;
using Core.Models.EfModels.Base;
using Core.Models.Utility;

namespace Core.Models.EfModels
{
    public class AppClaimGroup : DatabaseEntityTranslated<int>
    {
        public Translations Allows { get; set; }
        public Translations Description { get; set; }

        public IEnumerable<AppClaimGroupAppClaim> AppClaims { get; set; }
        public IEnumerable<AppClaimGroupFamily> AppClaimGroupsParent { get; set; }
        public IEnumerable<AppClaimGroupFamily> AppClaimGroupsChild { get; set; }
    }
}
