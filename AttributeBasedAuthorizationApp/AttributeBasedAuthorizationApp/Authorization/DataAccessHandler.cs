using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
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
           RouteData routeData = _httpContextAccessor.HttpContext.GetRouteData();
           return Task.CompletedTask;
        }
    }
}
