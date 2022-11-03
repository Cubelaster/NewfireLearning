using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class CardIdentificationNumberRange : CodebookCompanyBase
    {
        public List<CardIdentificationNumber> CardIdentificationNumbers { get; set; }
    }
}
