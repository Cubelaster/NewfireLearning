using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class CardType : CodebookCompanyBase
    {
        [StringLength(40)]
        public string ExternalCode { get; set; }
        public string Description { get; set; }
        public int AppCodeId { get; set; }
        public AppCode AppCode { get; set; }
    }
}
