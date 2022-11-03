using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Configs
{
    public class EntityGridColumnConfig : DatabaseEntity<int>
    {
        public EntityType SettingForEntityType { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(60)]
        public string PropertyName { get; set; }

        // Initially shown basically
        public bool IsHidden { get; set; } = true;
        // If it is used in grid at all
        public bool IsExposed { get; set; } = true;
        // If editing is allowed
        public bool IsEditable { get; set; } = true;

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public string AdditionalConfig { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}