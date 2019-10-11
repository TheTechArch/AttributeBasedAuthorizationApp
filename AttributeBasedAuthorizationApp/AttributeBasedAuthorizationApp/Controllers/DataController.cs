using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedAuthorizationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET: api/Data
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            ClaimsPrincipal claimsPrincipal = User;
            return new string[] { "value1", "value2" };
        }

        // GET: api/Data/5

        [HttpGet("{dataid}", Name = "Get")]
        [Authorize(Policy = "DataRead")]
        public string Get(int id)
        {
            ClaimsPrincipal claimsPrincipal = User;
           return "value";
        }

        // POST: api/Data
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Data/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
