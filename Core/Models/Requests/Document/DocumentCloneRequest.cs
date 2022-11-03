using System.Collections.Generic;

namespace Core.Models.Requests.Document
{
    /// <summary>
    /// Only used when you need to Clone/Copy instances
    /// It's configured inside it's Profile to remove all Ids
    /// </summary>
    public class DocumentCloneRequest : DocumentCreateRequest
    {
        public new List<DocumentItemCloneRequest> Items { get; set; }
    }
}
