using Core.Models.Requests.Filtering.Base;

namespace Core.Models.Requests.Filtering
{
    public class StoredProcedureReportFilterRequest : BaseFilterRequest
    {
        public string ConnectionStringName { get; set; }
        public string StoredProcedureName { get; set; }
        public string StoredProcedureSchema { get; set; }

        public string Note { get; set; }
    }
}
