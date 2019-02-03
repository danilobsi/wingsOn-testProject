using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Bus.Contract
{
    public class BookingContract: IBookingContract
    {
        IRepository<Domain.Person> personRepository;
        IRepository<Domain.Booking> bookingRepository;
        IPassengersContract passengerContract;
        IFlightsContract flightsContract;

        public BookingContract(
            IRepository<Domain.Person> personRepository, 
            IRepository<Domain.Booking> bookingRepository, 
            IPassengersContract passengerContract,
            IFlightsContract flightsContract)
        {
            this.personRepository = personRepository;
            this.bookingRepository = bookingRepository;
            this.passengerContract = passengerContract;
            this.flightsContract = flightsContract;
        }

        public string Create(Person passenger, int flightId)
        {
            var flight = flightsContract.Get(flightId);

            passenger = passengerContract.Create(passenger);

            var booking = new Booking
            {
                Passengers = new List<Person>
                {
                    passenger
                },
                Customer = passenger,
                Flight = flight,
                DateBooking = DateTime.Now,
                Number = NewBookingNumber()
            };

            bookingRepository.Save(booking);

            return "Booking created";
        }

        string NewBookingNumber()
        {
            return new Random().Next().ToString();
        }
    }
}
