using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Bus.Test.Mock
{
    public class MockBookingRepository
    {
        List<Booking> Repository;

        public MockBookingRepository()
        {
            var person = new MockPersonRepository();
            CultureInfo cultureInfo = new CultureInfo("nl-NL");

            Repository = new List<Booking>();

            Repository.AddRange(new[]
            {
                new Booking
                {
                    Id = 55,
                    Number = "WO-291470",
                    Customer = person.GetAll().Single(p => p.Name == "Branden Johnston"),
                    DateBooking = DateTime.Parse("03/03/2006 14:30", cultureInfo),
                    Flight = new Flight {
                        ArrivalAirport = new Airport(),
                        Id = 30,
                        Number = "PZ696",
                        DepartureAirport = new Airport(),
                        DepartureDate = DateTime.Parse("12/02/2012 16:50", cultureInfo),
                        ArrivalDate = DateTime.Parse("13/02/2012 00:00", cultureInfo),
                        Carrier = new Airline(),
                        Price = 196.1m
                    },
                    Passengers = new []
                    {
                        person.GetAll().Single(p => p.Name == "Branden Johnston")
                    }
                }
            });
        }

        public Booking Get(int id) => Repository.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Booking> GetAll() => Repository;
    }
}
