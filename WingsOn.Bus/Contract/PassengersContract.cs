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

        public Domain.Person Get(int id)
        {
            return Helper.RunMethod(() => personRepository.Get(id));
        }

        public List<Domain.Person> GetByFlight(string flightId)
        {
            return Helper.RunMethod(() => bookingRepository.GetAll()
                .Where(booking => booking.Flight.Number == flightId)
                .Select(booking => booking.Passengers.ToList())
                .FirstOrDefault() ?? new List<Person>());
        }

        public List<Domain.Person> GetByGender(GenderType gender)
        {
            return Helper.RunMethod(() => personRepository.GetAll()
                .Where(person => person.Gender == gender)
                .ToList());
        }

    }
}
