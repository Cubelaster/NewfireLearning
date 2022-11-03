using System.Collections.Generic;

namespace Core.Models.ViewModels.Reporting
{
    public class StoredProcedureReportDetailViewModel : StoredProcedureReportBaseViewModel
    {
        public List<StoredProcedureReportParamViewModel> ReportParams { get; set; }
    }
}
