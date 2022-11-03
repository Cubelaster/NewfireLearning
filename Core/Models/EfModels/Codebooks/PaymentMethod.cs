using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Promotions;

namespace Core.Models.EfModels.Codebooks
{
    public class PaymentMethod : CodebookCompanyBase
    {
        public int PaymentGroupId { get; set; }
        public AppCode PaymentGroup { get; set; }

        public IEnumerable<PromotionPayment> PromotionPayments { get; set; }
        public IEnumerable<DocumentPayment> DocumentPayments { get; set; }
    }
}
