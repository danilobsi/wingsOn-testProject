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
                    return new HttpResponseMessage(HttpStatusCode.NoContent);

                if (result is IEnumerable<T>)
                    return new HttpResponseMessage(((IList<T>)result).Count == 0 ? HttpStatusCode.NoContent : HttpStatusCode.OK);

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}