using System.Reflection;

namespace Utilities
{
    public static class ObjectExtensions
    {
        public static void MapProperties<T>(this T source, T target)
        {
            if (source != null && target != null)
            {
                var targetProps = GetObjectPropertiesUnsafe(target);
                var sourceProps = GetObjectPropertiesForFamilyUnsafe(source);
                foreach (var propEntry in targetProps)
                {
                    propEntry.Value.SetValue(target, sourceProps[propEntry.Key]);
                }
            }
        }

        /// <summary>
        /// This one is used for getting correct object properties when dealing with
        /// A family of objects
        /// Meaning that if we override a property, we match the correct type association here
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Dictionary<string, object> GetObjectPropertiesForFamilyUnsafe(this object entity)
        {
            return entity.GetType().GetProperties()
                .GroupBy(e => e.Name)
                .ToDictionary(p => p.Key,
                    p => p.OrderByDescending(e => e.DeclaringType.Name == entity.GetType().Name)
                    .First()
                        .GetValue(entity));
        }

        /// <summary>
        /// This one is used for getting correct object properties when dealing with
        /// A family of objects
        /// Meaning that if we override a property, we match the correct type association here
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Dictionary<string, PropertyInfo> GetObjectPropertiesUnsafe(this object entity)
        {
            return entity.GetType().GetProperties()
                .GroupBy(e => e.Name)
                .ToDictionary(p => p.Key,
                    p => p.OrderByDescending(e => e.DeclaringType.Name == entity.GetType().Name)
                    .First());
        }
    }
}