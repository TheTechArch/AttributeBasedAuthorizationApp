using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AttributeBasedAuthorizationApp.Authorization
{


    public class DataAccessHandler: AuthorizationHandler<DataAccessRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DataAccessHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DataAccessRequirement requirement)
        {
           ClaimsPrincipal user = context.User;
           
           // Verifies that a user is authenticated
           if (!user.Identity.IsAuthenticated)
           {
                context.Fail();
                return Task.CompletedTask;
           }

           if (DateTime.Now.Millisecond > 500)
            {
                context.Fail();
                context.
                return Task.CompletedTask;
            }
        

           RouteData routeData = _httpContextAccessor.HttpContext.GetRouteData();

           context.Succeed(requirement);
           return Task.CompletedTask;
        }
    }
}
