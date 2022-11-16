using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Configs;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Company : DatabaseEntity<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required]
        public string Code { get; set; }

        public IEnumerable<CompanyUser> Users { get; set; }

        #region Config

        public IEnumerable<EntityGridColumnConfig> EntityGridColumnConfigs { get; set; }
        public IEnumerable<EntityReport> EntityReports { get; set; }
        public IEnumerable<StoredProcedureReport> StoredProcedureReports { get; set; }
        public IEnumerable<StoredProcedureReportParam> StoredProcedureReportParams { get; set; }


        #endregion Config
    }
}
