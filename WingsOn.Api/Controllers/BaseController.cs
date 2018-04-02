using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WingsOn.Api.Controllers
{
    public class BaseController: ApiController
    {
        /// <summary>
        /// Creates HttpResponse from method execution
        /// </summary>
        /// <typeparam name="T">Object's type for the response</typeparam>
        /// <param name="func">Method to be executed</param>
        /// <returns>HttpResponse with the Method's response</returns>
        protected HttpResponseMessage CreateResponse<T>(Func<T> func)
        {
            try
            {
                var result = func();
                if (result == null)
                    return Request.CreateResponse(HttpStatusCode.NoContent, result);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}