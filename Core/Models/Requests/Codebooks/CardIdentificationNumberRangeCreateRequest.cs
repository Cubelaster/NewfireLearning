using System.Collections.Generic;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CardIdentificationNumberRangeCreateRequest : CodebookBaseCreateRequest
    {
        public List<CardIdentificationNumberCreateRequest> CardIdentificationNumbers { get; set; }
    }
}
