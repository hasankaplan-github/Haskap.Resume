using Haskap.DddBase.Infrastructure.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Haskap.Resume.Ui.MvcUi.Middlewares;

public class CustomAuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
{
    private readonly AuthorizationMiddlewareResultHandler defaultHandler = new AuthorizationMiddlewareResultHandler();

    //private readonly LoggedInUserProvider<Guid?> loggedInUserProvider;
    //private readonly ApplicationIdProvider applicationIdProvider;

    //public CustomAuthorizationMiddlewareResultHandler(LoggedInUserProvider<Guid?> loggedInUserProvider, ApplicationIdProvider applicationIdProvider)
    //{
    //    this.loggedInUserProvider = loggedInUserProvider;
    //    this.applicationIdProvider = applicationIdProvider;
    //}

    public async Task HandleAsync(
        RequestDelegate requestDelegate,
        HttpContext httpContext,
        AuthorizationPolicy authorizationPolicy,
        PolicyAuthorizationResult policyAuthorizationResult)
    {
        //var defaultUserIdClaim = new Claim(CustomClaimTypes.UserId, Guid.Empty.ToString());
        //var userIdClaim = httpContext.User.Claims.Where(x => x.Type == CustomClaimTypes.UserId).SingleOrDefault(defaultUserIdClaim);
        //loggedInUserProvider.UserId = Guid.Parse(userIdClaim.Value);

        //var defaultAuthorizedApplicationIdsClaim = new Claim(CustomClaimTypes.AuthorizedApplicationIds, "1");
        //var applicationIdClaim = httpContext.User.Claims.Where(x => x.Type == CustomClaimTypes.AuthorizedApplicationIds).SingleOrDefault(defaultAuthorizedApplicationIdsClaim);
        //applicationIdProvider.AuthorizedApplicationIds = applicationIdClaim.Value
        //    .Split(',', StringSplitOptions.RemoveEmptyEntries)
        //    .Select(int.Parse)
        //    .ToList();


        // Fallback to the default implementation.
        await defaultHandler.HandleAsync(requestDelegate, httpContext, authorizationPolicy,
                               policyAuthorizationResult);
    }
}
