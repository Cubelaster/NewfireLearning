using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace Workspaces.Infrastructure.Converters
{
    internal class TypeJsonConverter<T> : ValueConverter<T, string>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public TypeJsonConverter() : base(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<T>(v))
        { }
    }
}