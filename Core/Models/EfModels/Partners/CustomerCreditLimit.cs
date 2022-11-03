using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Partners
{
    public class CustomerCreditLimit : DatabaseEntity<Guid>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public decimal Amount { get; set; }
        public bool IsAdditional { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public string Note { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
