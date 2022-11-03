using Core.Enums;

namespace Core.Models.ViewModels.Base
{
    public interface IBaseViewModel<T> where T : struct
    {
        T EntityId { get; }
        EntityType EntityType { get; }
        string DisplayValue { get; }
    }
}
