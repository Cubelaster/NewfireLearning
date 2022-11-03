using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class DirectDeliveryPoint : CodebookCompanyBase
    {
        public IEnumerable<Document> Documents { get; set; }
    }
}
