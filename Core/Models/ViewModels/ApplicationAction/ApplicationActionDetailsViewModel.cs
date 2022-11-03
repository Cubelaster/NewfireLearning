using System.Collections.Generic;

namespace Core.Models.ViewModels.ApplicationAction
{
    public class ApplicationActionDetailsViewModel : ApplicationActionViewModel
    {
        public List<AuditLogViewModel> AuditLogs { get; set; }
    }
}
