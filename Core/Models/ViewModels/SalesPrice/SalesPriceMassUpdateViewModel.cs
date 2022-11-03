namespace Core.Models.ViewModels.SalesPrice
{
    // This is so we can split logic for AutoMapper <3
    public class SalesPriceMassUpdateViewModel : SalesPriceViewModel
    {
        public bool MarginCalculation { get; set; }
    }
}
