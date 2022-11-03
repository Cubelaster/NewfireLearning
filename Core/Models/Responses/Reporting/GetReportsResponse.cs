using System.Collections.Generic;
using Core.Models.ViewModels.Reporting;

namespace Core.Models.Responses.Reporting
{
    public class GetReportsResponse
    {
        public List<ReportingServiceReportViewModel> value { get; set; }
    }
}
