using System.Collections.Generic;
using Core.Models.ViewModels.Reporting;

namespace Core.Models.Responses.Reporting
{
    public class StoredProcedureRunResult
    {
        public List<StoredProcedureReportParamViewModel> Columns { get; set; }
        public string Result { get; set; }
        public List<object> Results { get; set; }
    }
}
