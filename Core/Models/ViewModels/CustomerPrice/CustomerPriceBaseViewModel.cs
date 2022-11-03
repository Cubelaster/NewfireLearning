using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.CustomerPrice
{
    public class CustomerPriceBaseViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public int PartnerId { get; set; }

        public int ArticleId { get; set; }

        public int DeliveryPointId { get; set; }

        public int ParityTermId { get; set; }
        public int PaymentTermId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? FixedPrice { get; set; }

        public int CompanyId { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.CustomerPrice;
        public string DisplayValue => "";
    }
}
