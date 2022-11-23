using System.Runtime.CompilerServices;
using System.Text;
using Core.Models.EfModels.Base;
using FluentValidation;
using ReActionResponse.Core;
using Workspaces.Application.Utility;
using Workspaces.Core.Services.Contracts.Utility;

namespace Workspaces.Application.Services.Implementations.Utility
{
    internal class ValidationService : IValidationService
    {
        private readonly IServiceProvider serviceProvider;

        public ValidationService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public ActionResponse Validate<T, U>(T entity)
            where T : DatabaseEntity<U>
            where U : struct
        {
            var validator = GetValidator<T, U>();
            if (validator != null)
            {
                var validationResult = validator.Validate(entity);

                if (validationResult.IsValid)
                {
                    return ActionResponse.Success();
                }
                else
                {
                    var stringBuilder = new StringBuilder();
                    validationResult.Errors.ForEach(e => stringBuilder.AppendLine(e.ErrorMessage));
                    return ActionResponse.Error(Message: stringBuilder.ToString());
                }
            }

            return ActionResponse.Success();
        }

        public AbstractValidator<T> GetValidator<T, U>() where T : DatabaseEntity<U>
            where U : struct
        {
            var validatorType = EntityTypeMatcher.GetEntityTypeConfig<T>().Validator;
            if (validatorType == null)
            {
                return null;
            }
            // I know, I know, Service Locator is an AntiPattern but it just works so well here
            return Unsafe.As<AbstractValidator<T>>(serviceProvider.GetService(validatorType));
        }
    }
}