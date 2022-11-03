using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Configs
{
    public class EntityReport : DatabaseEntity<int>
    {
        public EntityType ForEntityType { get; set; }

        [StringLength(255)]
        public string Path { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
