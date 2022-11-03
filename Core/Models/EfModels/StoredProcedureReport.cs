using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class StoredProcedureReport : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty]
        [StringLength(20)]
        public string ConnectionStringName { get; set; }
        [ReFilterProperty]
        [StringLength(60)]
        public string StoredProcedureName { get; set; }
        [StringLength(20)]
        public string StoredProcedureSchema { get; set; }

        public string Note { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<StoredProcedureReportParam> ReportParams { get; set; }
    }
}
