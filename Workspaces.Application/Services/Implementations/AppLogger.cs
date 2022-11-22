using System.Runtime.CompilerServices;
using System.Text;
using Core.Services.Contracts;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ReActionResponse.Core;

namespace Workspaces.Application.Services.Implementations
{
    internal class AppLogger : IAppLogger
    {
        private readonly ILogger<AppLogger> logger;

        public AppLogger(ILogger<AppLogger> logger)
        {
            this.logger = logger;
        }

        public ActionResponse LogError(string message,
            Exception exception,
            object parameters,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Logging error message.");
            stringBuilder.AppendLine(message);
            stringBuilder.AppendLine($"Logging occured inside \"{memberName}\", " +
                $"located in \"{sourceFilePath}\", from line \"{sourceLineNumber}\"");

            if (parameters != null)
            {
                stringBuilder.AppendLine($"Parameters used for this are: {Environment.NewLine}" +
                    $"{JsonConvert.SerializeObject(parameters)}");

                // We need to sanitaze this
                stringBuilder.Replace("{", "{{").Replace("}", "}}");
            }

            var realException = exception;
            while (realException.InnerException != null)
            {
                realException = realException.InnerException;
            }

            stringBuilder.AppendLine($"Error message is: {Environment.NewLine}" +
                $"Message: {realException.Message}{Environment.NewLine}");

            logger.LogError(stringBuilder.ToString(), exception);

            return ActionResponse.Error(Message: message);
        }

        public ActionResponse<T> LogError<T>(string message,
            Exception exception,
            object parameters,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Logging error message.");
            stringBuilder.AppendLine(message);
            stringBuilder.AppendLine($"Logging occured inside \"{memberName}\", located in \"{sourceFilePath}\", from line \"{sourceLineNumber}\"");

            if (parameters != null)
            {
                stringBuilder.AppendLine($"Parameters used for this are: {Environment.NewLine}" +
                    $"{JsonConvert.SerializeObject(parameters)}");
            }

            stringBuilder.AppendLine($"Error message is: {Environment.NewLine}" +
                $"Message: {exception.Message}{Environment.NewLine}");

            logger.LogError(stringBuilder.ToString(), exception);

            return ActionResponse<T>.Error(Message: message);
        }
    }
}
