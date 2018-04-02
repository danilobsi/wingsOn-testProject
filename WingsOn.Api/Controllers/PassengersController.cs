using System.Net.Http;
using WingsOn.Bus;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Api.Controllers
{
    public class PassengersController : BaseController
    {
        PassengersContract passengersContract = new PassengersContract(new PersonRepository(), new BookingRepository());

        public HttpResponseMessage Get(int id) => CreateResponse(() =>
            passengersContract.Get(id)
        );

        public HttpResponseMessage GetByFlight(string flightId) => CreateResponse(() =>
            passengersContract.GetByFlight(flightId)
        );

        public HttpResponseMessage GetByGender(GenderType gender) => CreateResponse(() =>
             passengersContract.GetByGender(gender)
        );
    }
}
