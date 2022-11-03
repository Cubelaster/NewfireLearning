using System;
using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using ReFilter.Attributes;

namespace Core.Models.EfModels.EntityConnectors
{
    public class EntityNote : DatabaseEntity<int>
    {
        public EntityType EntityType { get; set; }
        public int EntityId { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(400)]
        public string Value { get; set; }

        public int NoteTypeId { get; set; }
        public NoteType NoteType { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
