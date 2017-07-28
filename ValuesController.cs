using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace APIAuthenction.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        public class BasicAuthentication : AuthorizationFilterAttribute
        {
            public override void OnAuthorization(HttpActionContext actionContext)
            {
                if (actionContext.Request.Headers.Authorization == null)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                }
                else
                {
                    var authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                    var decodeAuthenticationToken = Encoding.UTF8.GetString(
                        Convert.FromBase64String(authenticationToken));
                    string[] credential = decodeAuthenticationToken.Split(':');

                }
            }

        }
        [BasicAuthentication]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}