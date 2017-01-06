using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientCacheDemo.Controllers
{
    public class CachePuclicController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            //在IE下有效但在chrome下无效，chrome还是会一直请求
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, DateTime.Now.ToBinary());

            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue();
            response.Headers.CacheControl.Public = true;

            return response;
        }
    }
}
