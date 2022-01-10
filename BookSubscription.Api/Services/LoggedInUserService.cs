using BookSubscription.Application.Interfaces;
using System.Security.Claims;

namespace BookSubscription.Api.Services
{
    public class LoggedInUserService: ILoggedInUserService
    {  
        public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; }
    }
}
