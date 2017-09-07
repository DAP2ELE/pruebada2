using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lupi.WebApi.Controllers
{
    public class BreedController : ApiController
    {
        // GET: api/Breed
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value" };
        }

        // GET: api/Breed/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Breed
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Breed/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Breed/5
        public void Delete(int id)
        {
        }
    }
}
