using System;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class ApplicationActionFilterRequest : IReFilterRequest
    {
        public int? ApplicationActionDefinitionId { get; set; }

        public int? ParentActionId { get; set; }

        public string Request { get; set; }
        public string Response { get; set; }
        public RangeFilter<DateTime> ActionStartTime { get; set; }
        public RangeFilter<DateTime> ActionEndTime { get; set; }
        public string ActionResult { get; set; }

        public Guid? CreatedById { get; set; }
    }
}
