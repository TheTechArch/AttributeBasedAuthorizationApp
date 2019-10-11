using System.Collections.Generic;
using AttributeBasedAuthorizationApp.Services;
using JWAttributeBasedAuthorizationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedAuthorizationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // POST: api/Authentication
        [HttpPost]
        public string Post([FromBody] AuthenticationRequest authenticationRequest)
        {
            AuthenticationService service = new AuthenticationService();
            string token = service.GetToken(authenticationRequest.userName, authenticationRequest.passWord);

            service.ValidateAndDecode(token);

            return token;
        }
    }
}
