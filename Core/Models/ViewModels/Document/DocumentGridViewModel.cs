using System;

namespace Core.Models.ViewModels.Document
{
    public class DocumentGridViewModel : DocumentBaseViewModel
    {
        public DateOnly? DeliveryDate { get; set; }

        public decimal ExchangeRate { get; set; }
        public decimal? CustomsExchangeRate { get; set; }
    }
}
