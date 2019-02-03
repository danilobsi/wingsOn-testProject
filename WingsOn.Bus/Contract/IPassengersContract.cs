using System.Collections.Generic;
using WingsOn.Domain;

namespace WingsOn.Bus
{
    public interface IPassengersContract
    {
        /// <summary>
        /// Gets person by Id
        /// </summary>
        /// <param name="id">Person's Id</param>
        /// <returns>Person's data</returns>
        Domain.Person Get(int id);

        /// <summary>
        /// Gets all the passengers by flight Number
        /// </summary>
        /// <param name="flightNumber">Passenger's Flight Number</param>
        /// <returns>List of Passenger</returns>
        List<Domain.Person> GetByFlight(string flightNumber);

        /// <summary>
        /// Gets all the passengers by gender
        /// </summary>
        /// <param name="gender">Passenger's Gender (Male or Female)</param>
        /// <returns>List of Passenger</returns>
        List<Domain.Person> GetByGender(GenderType gender);

        /// <summary>
        /// Create a new passenger
        /// </summary>
        /// <param name="passenger">Passenger to be created</param>
        /// <returns>Created passenger</returns>
        Person Create(Person passenger);
    }
}