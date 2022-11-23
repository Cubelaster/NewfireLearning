using System.Runtime.CompilerServices;
using ReActionResponse.Core;

namespace Workspaces.Core.Services.Contracts.Utility
{
    public interface IAppLogger
    {
        ActionResponse LogError(string message,
            Exception exception,
            object parameters,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0);
    }
}
