using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Base
{
    public abstract class DatabaseEntity<T> : DatabaseEntity
    {
        [Column(Order = 0)]
        public T Id { get; set; }
    }

    public abstract class DatabaseEntity
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsDeleted { get; set; }

        public Guid? CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public Guid? LastModifiedById { get; set; }
        public User LastModifiedBy { get; set; }
    }
}
