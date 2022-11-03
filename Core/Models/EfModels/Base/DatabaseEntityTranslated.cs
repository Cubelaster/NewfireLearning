using Core.Models.Utility;

namespace Core.Models.EfModels.Base
{
    public class DatabaseEntityTranslated<T> : DatabaseEntity<T> where T : struct
    {
        public Translations Translations { get; set; }
    }
}
