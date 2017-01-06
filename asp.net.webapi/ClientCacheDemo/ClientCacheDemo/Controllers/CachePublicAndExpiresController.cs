using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientCacheDemo.Controllers
{
    public class CachePublicAndExpiresController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            //chrome下加上Expires解决问题;
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, DateTime.Now.ToBinary());
            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue();
            response.Headers.CacheControl.Public = true;
            response.Content.Headers.Expires = DateTimeOffset.Now.AddDays(20);

            return response;
        }
    }
}
