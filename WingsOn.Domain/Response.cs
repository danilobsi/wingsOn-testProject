using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WingsOn.Domain
{
    public class Response<T>
    {
        public T Object { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
