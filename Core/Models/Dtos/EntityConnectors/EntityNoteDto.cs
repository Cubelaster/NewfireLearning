using System;
using Core.Models.Dtos.EntityConnectors.Base;
using Core.Models.ViewModels.Codebooks.EntityConnectorTypeViewModels;

namespace Core.Models.Dtos.EntityConnectors
{
    public class EntityNoteDto : EntityConnectorBaseDto
    {
        public int NoteTypeId { get; set; }
        public NoteTypeViewModel NoteType { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
