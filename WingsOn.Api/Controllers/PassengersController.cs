using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WingsOn.Bus;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Api.Controllers
{
    public class PassengersController : BaseController
    {
        PassengersContract passengersContract = new PassengersContract(new PersonRepository(), new BookingRepository());

        // GET api/passengers/5
        public HttpResponseMessage Get(int id) => CreateResponse(() =>
            passengersContract.Get(id)
        );

        // GET api/passengers/PZ696
        public HttpResponseMessage GetByFlight(string flightId) => CreateResponse(() =>
            passengersContract.GetByFlight(flightId)
        );

        // GET api/passengers/Male
        public HttpResponseMessage GetByGender(GenderType gender) => CreateResponse(() =>
             passengersContract.GetByGender(gender)
        );
    }
}
