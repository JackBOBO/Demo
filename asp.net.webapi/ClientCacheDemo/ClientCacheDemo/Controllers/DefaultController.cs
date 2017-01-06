using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientCacheDemo.Controllers
{
    public class DefaultController : ApiController
    {
        //[HttpGet]
        //public string CacheTest()
        //{

        //    //this.ActionContext.Response = new HttpResponseMessage();
        //    //this.ActionContext.Response.Headers.Add("Cache-Control", "private");
        //    //this.ActionContext.Response.Headers.Add("Expires", "3000");
        //    return string.Format("hello, world({0})!", DateTime.Now.ToBinary());
        //}

        [HttpGet]
        public HttpResponseMessage CacheTest1()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, DateTime.Now.ToBinary());
            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue();
            response.Headers.CacheControl.Public = true;
            //response.Content.Headers.Expires = DateTimeOffset.Now.AddDays(20);

            return response;
        }

        [HttpGet]
        public HttpResponseMessage CacheTestTest()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, DateTime.Now.ToBinary());

            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue();
            response.Headers.CacheControl.Public = true;

            return response;
        }
    }
}
