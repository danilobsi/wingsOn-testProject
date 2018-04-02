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
        protected HttpResponseMessage CreateResponse<T>(Func<T> func)
        {
            try
            {

                var result = func();
                if (result == null)
                    return Request.CreateResponse(HttpStatusCode.NoContent, result);

                if (result is IEnumerable<T>)
                    return Request.CreateResponse(
                        ((IList<T>)result).Count == 0 ? HttpStatusCode.NoContent : HttpStatusCode.OK,
                        result);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}