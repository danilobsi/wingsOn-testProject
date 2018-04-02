using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOn.Bus.Util;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Bus
{
    public class PassengersContract
    {
        IRepository<Domain.Person> personRepository;
        IRepository<Domain.Booking> bookingRepository;
        public PassengersContract(IRepository<Domain.Person> personRepository, IRepository<Domain.Booking> bookingRepository)
        {
            this.personRepository = personRepository;
            this.bookingRepository = bookingRepository;
        }

        /// <summary>
        /// Gets person by Id
        /// </summary>
        /// <param name="id">Person's Id</param>
        /// <returns>Person's data</returns>
        public Domain.Person Get(int id)
        {
            return Helper.RunMethod(() => personRepository.Get(id));
        }

        /// <summary>
        /// Gets all the passengers by flight Number
        /// </summary>
        /// <param name="flightNumber">Passenger's Flight Number</param>
        /// <returns>List of Passenger</returns>
        public List<Domain.Person> GetByFlight(string flightNumber)
        {
            return Helper.RunMethod(() => bookingRepository.GetAll()
                .Where(booking => booking.Flight.Number == flightNumber)
                .Select(booking => booking.Passengers.ToList())
                .FirstOrDefault() ?? new List<Person>());
        }

        /// <summary>
        /// Gets all the passengers by gender
        /// </summary>
        /// <param name="gender">Passenger's Gender (Male or Female)</param>
        /// <returns>List of Passenger</returns>
        public List<Domain.Person> GetByGender(GenderType gender)
        {
            return Helper.RunMethod(() => personRepository.GetAll()
                .Where(person => person.Gender == gender)
                .ToList());
        }

    }
}
