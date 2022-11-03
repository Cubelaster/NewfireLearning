using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Reporting
{
    public class StoredProcedureReportUpdateRequest : StoredProcedureReportCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }

        public new List<StoredProcedureReportParamUpdateRequest> ReportParams { get; set; }
    }
}
