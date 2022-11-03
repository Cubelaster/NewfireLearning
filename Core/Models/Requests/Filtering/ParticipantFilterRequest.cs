using System;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class ParticipantFilterRequest : BaseFilterRequest
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }

        public int? ParticipantTypeId { get; set; }
        public int? TransporterId { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
    }
}
