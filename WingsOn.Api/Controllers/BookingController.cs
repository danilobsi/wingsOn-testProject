using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WingsOn.Bus;
using WingsOn.Bus.Contract;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Api.Controllers
{
    public class BookingController: BaseController
    {
        BookingContract bookingContract = new BookingContract(
            new PersonRepository(),
            new BookingRepository(),
            new PassengersContract(
                new PersonRepository(),
                new BookingRepository()),
            new FlightsContract(new FlightRepository())
            );

        [HttpPost]
        public HttpResponseMessage CreateBooking([FromBody] Person passenger, [FromUri] int flightId) => CreateResponse(() =>
             bookingContract.Create(passenger, flightId)
        );
    }
}