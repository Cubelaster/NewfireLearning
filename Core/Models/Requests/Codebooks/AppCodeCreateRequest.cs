using Core.Enums;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Codebooks
{
    public class AppCodeCreateRequest : BaseRequest
    {
        public EntityType EntityType { get; set; }
        public int Key { get; set; }
        public string Name { get; set; }

        public int? SortOrder { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }

        public Translations Translations { get; set; }
    }
}
