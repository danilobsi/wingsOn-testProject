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

        /// <summary>
        /// Gets person by Id
        /// </summary>
        /// <param name="id">Person's Id</param>
        /// <returns>Person's data</returns>
        public HttpResponseMessage Get(int id) => CreateResponse(() =>
            passengersContract.Get(id)
        );

        /// <summary>
        /// Gets all the passengers by flight Number
        /// </summary>
        /// <param name="flightNumber">Passenger's Flight Number</param>
        /// <returns>List of Passenger</returns>
        public HttpResponseMessage GetByFlight(string flightNumber) => CreateResponse(() =>
            passengersContract.GetByFlight(flightNumber)
        );

        /// <summary>
        /// Gets all the passengers by gender
        /// </summary>
        /// <param name="gender">Passenger's Gender (Male or Female)</param>
        /// <returns>List of Passenger</returns>
        public HttpResponseMessage GetByGender(GenderType gender) => CreateResponse(() =>
             passengersContract.GetByGender(gender)
        );
    }
}
