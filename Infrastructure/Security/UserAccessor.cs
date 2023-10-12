using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _htppContextAccessor;
        public UserAccessor(IHttpContextAccessor htppContextAccessor)
        {
            _htppContextAccessor = htppContextAccessor;
            
        }
        public string GetUsername()
        {
            return _htppContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
    }
}