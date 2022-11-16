using Core.Models.Utility;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace Workspaces.Infrastructure.Converters
{
    public class TranslationsConverter : ValueConverter<Translations, string>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public TranslationsConverter() : base(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Translations>(v))
        { }
    }
}
