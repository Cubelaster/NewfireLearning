using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels
{
    public class PurchasePrice : DatabaseEntity<Guid>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public decimal Price { get; set; }
        public decimal RebateAmount { get; set; }
        public decimal RebatePercentage { get; set; }
        public decimal ExciseDuty { get; set; }
        public decimal PriceNet { get; set; }
        public bool MarginCalculation { get; set; }

        public bool IsAction { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
