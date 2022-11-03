using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;

namespace Core.Models.Requests.Filtering
{
    public class RoleFilterRequest : BaseFilterRequest
    {
        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? IsSuperAdmin { get; set; }
    }
}
