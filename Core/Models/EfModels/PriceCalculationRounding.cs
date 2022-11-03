using System.Collections.Generic;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    /// <summary>
    /// The logic for this is next: 
    /// Intervals define "named" intervals 0 < x < 1 where we split the decimal part
    /// Namely, those are 0.33, 0.25, 0.72 (so 3 intervals, 4 intervals, or fixed 1)
    /// We don't use straight number because this seems to give us more options
    /// And then we have Modifier that is meant to be 0 < Abs|x| < 1 and work as a modifier on top of decimal number
    /// For instance, 0.2 would be added to any decimal place in the number, while -0.05 would be subtracted from it
    /// Basically, we take an existing decimal part (if any) and split it according to Intervals (if any split) and then just slap Modifier on it
    /// </summary>
    public class PriceCalculationRounding : DatabaseEntityTranslated<int>
    {
        public decimal? Modifier { get; set; }
        public decimal? Intervals { get; set; }

        public int PriceCalculationRoundingTypeId { get; set; }
        public PriceCalculationRoundingType PriceCalculationRoundingType { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<PurchasePrice> PurchasePrices { get; set; }
        public List<SalesPrice> SalesPrices { get; set; }
    }
}
