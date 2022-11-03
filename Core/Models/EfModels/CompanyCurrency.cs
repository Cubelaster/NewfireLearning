using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class CompanyCurrency : DatabaseEntity<int>
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
