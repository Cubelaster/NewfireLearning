using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace Workspaces.Infrastructure.Converters
{
    internal class TypeJsonValueComparer<T> : ValueComparer<T>
    {
        public TypeJsonValueComparer() : base(
            (e1, e2) => e1.Equals(e2),
            e => e.GetHashCode(),
            e => JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(e)))
        { }
    }
}
