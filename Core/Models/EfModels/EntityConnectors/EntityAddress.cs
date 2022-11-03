using System;
using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using ReFilter.Attributes;

namespace Core.Models.EfModels.EntityConnectors
{
    public class EntityAddress : DatabaseEntity<int>
    {
        public EntityType EntityType { get; set; }
        public int EntityId { get; set; }

        public int? CountryId { get; set; }
        public Country Country { get; set; }

        public int? PostalCodeId { get; set; }
        public PostalCode PostalCode { get; set; }

        public int AddressTypeId { get; set; }
        public AddressType AddressType { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(400)]
        public string Value { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(255)]
        public string ValueExtension { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(4000)]
        public string Description { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
