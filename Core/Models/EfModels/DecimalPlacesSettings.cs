using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class DecimalPlacesSettings : DatabaseEntity<int>
    {
        public EntityType SettingForEntityType { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(60)]
        public string PropertyName { get; set; }

        public int DecimalPlaces { get; set; }
        public int? TotalCharacters { get; set; }
        public bool HasLeadingZeroes { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
