using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Logging
{
    public class ApplicationActionDefinition : DatabaseEntity<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        public string ActionOwnerName { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        public string ActionName { get; set; }
        public string RequestSignature { get; set; }
        public string ResponseSignature { get; set; }
    }
}
