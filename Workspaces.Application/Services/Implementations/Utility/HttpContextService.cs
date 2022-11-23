using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Workspaces.Core.Services.Contracts.Utility;

namespace Workspaces.Application.Services.Implementations.Utility
{
    internal class HttpContextService : IHttpContextService
    {
        #region Ctors and Members

        private readonly IHttpContextAccessor contextAccessor;

        public HttpContextService(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        #endregion Ctors and Members

        public Guid? CurrentUserId
        {
            get
            {
                var userStringId = contextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                return Guid.TryParse(userStringId, out Guid userId) ? userId : null;
            }
        }

        public ClaimsPrincipal CurrentUser
        {
            get
            {
                return contextAccessor?.HttpContext?.User;
            }
        }
    }
}
