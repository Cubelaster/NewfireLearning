using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class ApplicationActionDefinitionFilterRequest : IReFilterRequest
    {
        public string Name { get; set; }

        public string ActionOwnerName { get; set; }
        public string ActionName { get; set; }
        public string RequestSignature { get; set; }
        public string ResponseSignature { get; set; }

        public RangeFilter<DateTime> DateCreated { get; set; }
        public RangeFilter<DateTime> DateModified { get; set; }
        public bool? IsDeleted { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public bool? IsActive { get; set; }

        [ReFilterProperty(HasSpecialSort = true)]
        public Guid? CreatedById { get; set; }
        [ReFilterProperty(HasSpecialSort = true)]
        public Guid? LastModifiedById { get; set; }
    }
}
