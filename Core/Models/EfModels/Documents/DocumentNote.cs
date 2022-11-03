using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Documents
{
    public class DocumentNote : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(400)]
        public string Value { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
