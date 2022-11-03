using System;
using System.Collections.Generic;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Logging
{
    public class ApplicationAction : DatabaseEntity<int>
    {
        public int ApplicationActionDefinitionId { get; set; }
        public ApplicationActionDefinition ApplicationActionDefinition { get; set; }

        public int? ParentActionId { get; set; }
        public ApplicationAction ParentAction { get; set; }

        public List<ApplicationAction> ChildActions { get; set; }

        public string Request { get; set; }
        public string Response { get; set; }
        public DateTime ActionStartTime { get; set; }
        public DateTime? ActionEndTime { get; set; }
        public string ActionResult { get; set; }

        public IEnumerable<AuditLog> AuditLogs { get; set; }
    }
}
