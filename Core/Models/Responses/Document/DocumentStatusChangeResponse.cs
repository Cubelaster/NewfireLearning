using System;

namespace Core.Models.Responses.Document
{
    public class DocumentStatusChangeResponse
    {
        public Guid? Id { get; set; }
        public int StatusId { get; set; }
        public int? TypeId { get; set; }
    }
}
