using System.Collections.Generic;
using Core.Models.ViewModels.Reporting;

namespace Core.Models.Requests.Reporting
{
    public class StoredProcedureRunRequest
    {
        public string ConnectionStringName { get; set; }
        public string StoredProcedureName { get; set; }
        public string StoredProcedureSchema { get; set; } = "dbo.";
        public List<ReportingServiceReportParamsViewModel> Params { get; set; }
    }
}
