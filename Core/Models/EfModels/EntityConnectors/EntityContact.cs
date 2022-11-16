using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels.EntityConnectors
{
    public class EntityContact : DatabaseEntity<int>
    {
        public EntityType EntityType { get; set; }
        public int EntityId { get; set; }

        //public int ContactTypeId { get; set; }
        //public ContactType ContactType { get; set; }

        public bool IsPreffered { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(400)]
        public string Value { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(4000)]
        public string Description { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
