using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Promotions
{
    public class PromotionPaymentDto : PromotionBaseDto
    {
        public int PaymentMethodId { get; set; }
        public PaymentMethodViewModel PaymentMethod { get; set; }
    }
}
