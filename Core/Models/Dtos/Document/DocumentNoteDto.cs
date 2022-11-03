using System;

namespace Core.Models.Dtos.Document
{
    public class DocumentNoteDto
    {
        public int? Id { get; set; }
        public Guid DocumentId { get; set; }
        public string Value { get; set; }
        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
