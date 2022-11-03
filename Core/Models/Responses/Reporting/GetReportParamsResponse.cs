using System.Collections.Generic;
using Core.Models.ViewModels.Reporting;

namespace Core.Models.Responses.Reporting
{
    public class GetReportParamsResponse
    {
        public List<ReportingServiceReportParamsViewModel> value { get; set; }
    }
}
