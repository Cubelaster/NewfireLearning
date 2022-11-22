using System.Runtime.CompilerServices;
using ReActionResponse.Core;

namespace Core.Services.Contracts
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
