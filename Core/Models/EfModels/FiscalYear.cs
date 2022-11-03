using System;
using System.Collections.Generic;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels
{
    public class FiscalYear : DatabaseEntity<int>
    {
        public int Year { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public bool IsLocked { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IEnumerable<Document> Documents { get; set; }
    }
}
