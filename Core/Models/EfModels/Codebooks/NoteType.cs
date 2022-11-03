using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class NoteType : MetaCarrierBase
    {
        public new NoteTypeMetaDto Meta { get; set; }
    }
}
