using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.Document
{
    public class DocumentPaymentViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public Guid DocumentId { get; set; }

        public PaymentMethodViewModel PaymentMethod { get; set; }
        public PartnerBaseViewModel Partner { get; set; }

        public decimal Amount { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.DocumentPayment;
        public string DisplayValue => $"{Amount}({PaymentMethod.DisplayValue} )";
    }
}
