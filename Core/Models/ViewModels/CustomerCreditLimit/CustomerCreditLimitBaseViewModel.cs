using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.CustomerCreditLimit
{
    public class CustomerCreditLimitViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public int PartnerId { get; set; }

        public decimal Amount { get; set; }
        public bool IsAdditional { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public string Note { get; set; }

        public int CompanyId { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.CustomerCreditLimit;
        public string DisplayValue => "";
    }
}
