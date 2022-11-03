using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Reporting
{
    public class StoredProcedureReportBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Translations Translations { get; set; }
        public string ConnectionStringName { get; set; }
        public string StoredProcedureName { get; set; }
        public string StoredProcedureSchema { get; set; } = "dbo.";

        public int EntityId => Id;
        public EntityType EntityType => EntityType.StoredProcedureReport;
        public string DisplayValue => $"{ConnectionStringName} {Name}";
    }
}
