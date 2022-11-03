using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks.EntityConnectorTypes
{
    public class NoteTypeCreateRequest : CodebookBaseCreateRequest
    {
        public NoteTypeMetaDto Meta { get; set; }
    }
}
