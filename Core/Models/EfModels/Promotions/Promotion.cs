using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Promotions
{
    public class Promotion : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(40)]
        public string Code { get; set; }

        public int PromotionTypeId { get; set; }
        public AppCode PromotionType { get; set; }

        public int CombinationTypeId { get; set; }
        public AppCode CombinationType { get; set; }

        public int DisplayTypeId { get; set; }
        public AppCode DisplayType { get; set; }

        public int MarketingActionTypeId { get; set; }
        public MarketingActionType MarketingActionType { get; set; }

        #region VALIDITY

        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }

        [StringLength(10)]
        public string Days { get; set; }

        #endregion VALIDITY

        public bool IsForForecourt { get; set; }

        public string MarketingMessage { get; set; }
        public int CodeLength { get; set; }

        public bool IsCombo { get; set; }
        public int ComboScale { get; set; } //ToDo: ne znamo sta je
        public decimal Price { get; set; }

        public bool IsBinRange { get; set; }

        [StringLength(40)]
        public string Psp { get; set; }

        public int OrderNo { get; set; }

        public bool ShowOnPos { get; set; }
        public bool ShowOnCustomerDisplay { get; set; }

        public bool IsActive { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [InverseProperty("ComboPromotion")]
        public ICollection<PromotionDiscount> ComboPromotionDiscounts { get; set; }

        #region CHILDREN

        [InverseProperty("Promotion")]
        public List<PromotionDiscount> Discounts { get; set; }
        public List<PromotionCondition> Conditions { get; set; }
        public List<PromotionNormative> Normatives { get; set; }
        public List<PromotionBinrangeGroup> BinrangeGroups { get; set; }
        public List<PromotionPayment> Payments { get; set; }
        public List<PromotionSite> Sites { get; set; }
        public List<PromotionImage> Images { get; set; }

        #endregion CHILDREN
    }
}
