using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class DocumentStatusViewModel : CodebookBaseViewModel
    {
        public new DocumentStatusEnum Code { get; set; }
        public DocumentStatusMetaDto Meta { get; set; }
    }
}
