using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Promotions
{
    public class PromotionPayment : PromotionChild
    {
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
