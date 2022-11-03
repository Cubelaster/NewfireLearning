using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class AppCode : DatabaseEntityTranslated<int>
    {
        public EntityType EntityType { get; set; }
        public int Key { get; set; }

        public int? SortOrder { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public string Meta { get; set; }
    }
}
