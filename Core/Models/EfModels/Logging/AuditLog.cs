using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Logging
{
    public class AuditLog : DatabaseEntity<int>
    {
        public int? ApplicationActionId { get; set; }
        public ApplicationAction ApplicationAction { get; set; }

        public string Changes { get; set; }
        [StringLength(100)]
        public string TableName { get; set; }
        [StringLength(20)]
        public string State { get; set; }
    }
}
