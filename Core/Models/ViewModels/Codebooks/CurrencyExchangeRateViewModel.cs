namespace Core.Models.ViewModels.Codebooks
{
    public class CurrencyExchangeRateViewModel : CurrencyExchangeRateBaseViewModel
    {
        public CurrencyViewModel Currency { get; set; }
        public CurrencyViewModel CurrencyRef { get; set; }

        public AppCodeViewModel Type { get; set; }

        public new string DisplayValue => $"{Currency.Code} - {ValidOn.ToShortDateString()}";
    }
}
