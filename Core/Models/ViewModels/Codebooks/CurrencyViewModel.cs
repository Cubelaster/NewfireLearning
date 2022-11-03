using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class CurrencyViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Symbol { get; set; }
        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Currency;
        public string DisplayValue => $"{Code}{(string.IsNullOrEmpty(Symbol) ? "" : "-" + Symbol)}";
    }
}
