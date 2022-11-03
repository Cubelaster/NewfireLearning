using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Reporting
{
    public class StoredProcedureReportCreateRequest : BaseRequest
    {
        public string ConnectionStringName { get; set; }
        public string StoredProcedureName { get; set; }
        public string StoredProcedureSchema { get; set; }

        public string Note { get; set; }

        public int CompanyId { get; set; }

        public List<StoredProcedureReportParamCreateRequest> ReportParams { get; set; }
    }
}
