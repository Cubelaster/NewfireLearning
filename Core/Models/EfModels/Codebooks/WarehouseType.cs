using System.Collections.Generic;
using Core.Enums;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class WarehouseType : CodebookBase
    {
        public new WarehouseTypeEnum Code { get; set; }

        public IEnumerable<Site> Sites { get; set; }
        public IEnumerable<DocumentType> DocumentTypes { get; set; }
    }
}
