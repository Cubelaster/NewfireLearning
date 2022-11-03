using System.Collections.Generic;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class CardIdentificationNumberRangeDetailViewModel : CodebookBaseViewModel
    {
        public List<CardIdentificationNumberViewModel> CardIdentificationNumbers { get; set; }
    }
}
