using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class CardIdentificationNumberViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public int RangeId { get; set; }

        public string Number { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;

        public EntityType EntityType => EntityType.CardIdentificationNumber;

        public string DisplayValue => $"{RangeId} - {Number}";
    }
}
