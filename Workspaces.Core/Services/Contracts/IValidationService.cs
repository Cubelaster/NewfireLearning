using Core.Models.EfModels.Base;
using ReActionResponse.Core;

namespace Workspaces.Core.Services.Contracts
{
    public interface IValidationService
    {
        ActionResponse Validate<T, U>(T entity) where T : DatabaseEntity<U> where U : struct;
    }
}
