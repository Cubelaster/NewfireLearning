using System.Collections.Generic;

namespace Core.Models.Utility
{
    public class ParentChildrenDto<T>
    {
        public T ParentId { get; set; }
        public List<T> ChildrenIds { get; set; }
    }
}
