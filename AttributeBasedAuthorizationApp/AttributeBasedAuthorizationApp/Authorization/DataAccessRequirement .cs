using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttributeBasedAuthorizationApp.Authorization
{
    public class DataAccessRequirement: IAuthorizationRequirement
    {

        public string Action { get;  }

        public DataAccessRequirement(string action)
        {

        }

    }
}
