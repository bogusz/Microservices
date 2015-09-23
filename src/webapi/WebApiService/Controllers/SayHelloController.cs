using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SayHelloController : ApiController
    {
        // GET: api/service        
        public IEnumerable<string> Get()
        {
            return new List<string>() { "Hello from WebApi service!" };
        }

        // GET: api/service/5
        public string Get(int id)
        {
            return "Hello from WebApi service with id: " + id;
        }
    }
}
