using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CardIdentificationNumberRangeUpdateRequest : CardIdentificationNumberRangeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }

        public new List<CardIdentificationNumberUpdateRequest> CardIdentificationNumbers { get; set; }
    }
}
