using System.Security.Claims;
using GloboTicket.Application.Contracts;
using Microsoft.AspNetCore.Http;

namespace GloboTicket.Api.Services
{
    public class LoggedInUserService : ILoggedInUserService
    {
        //public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        //{
        //    UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        //}

        public string UserId { get; }
    }
}
