using System;
using System.Globalization;
using System.Linq;
using WingsOn.Domain;

namespace WingsOn.Dal
{
    public class FlightRepository : RepositoryBase<Flight>
    {
        public FlightRepository() 
        {
            AirportRepository airports = new AirportRepository();
            AirlineRepository airlines = new AirlineRepository();
            CultureInfo cultureInfo = new CultureInfo("nl-NL");

            Repository.AddRange(new []
            {
                new Flight
                {
                    Id = 30,
                    Number = "BB124",
                    DepartureAirport = airports.GetAll().Single(a => a.Code == "OQO"),
                    DepartureDate = DateTime.Parse("12/02/2012 16:50", cultureInfo),
                    ArrivalAirport =  airports.GetAll().Single(a => a.Code == "GJE"),
                    ArrivalDate = DateTime.Parse("13/02/2012 00:00", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "BB"),
                    Price = 196.1m
                },
                new Flight
                {
                    Id = 81,
                    Number = "PZ696",
                    DepartureAirport = airports.GetAll().Single(a => a.Code == "GJE"),
                    DepartureDate = DateTime.Parse("20/02/2000 17:50", cultureInfo),
                    ArrivalAirport =  airports.GetAll().Single(a => a.Code == "CZR"),
                    ArrivalDate = DateTime.Parse("20/02/2000 19:00", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "PZ"),
                    Price = 95.2m
                },
                new Flight
                {
                    Id = 41,
                    Number = "BB339",
                    ArrivalAirport = airports.GetAll().Single(a => a.Code == "ANH"),
                    ArrivalDate = DateTime.Parse("20/02/2000 17:50", cultureInfo),
                    DepartureAirport =  airports.GetAll().Single(a => a.Code == "GJE"),
                    DepartureDate = DateTime.Parse("20/02/2000 19:00", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "BB"),
                    Price = 57.6m
                },
                new Flight
                {
                    Id = 12,
                    Number = "BB910",
                    ArrivalAirport = airports.GetAll().Single(a => a.Code == "GJE"),
                    ArrivalDate = DateTime.Parse("17/07/2009 11:10", cultureInfo),
                    DepartureAirport =  airports.GetAll().Single(a => a.Code == "OQO"),
                    DepartureDate = DateTime.Parse("17/07/2009 13:45", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "BB"),
                    Price = 185m
                },
                new Flight
                {
                    Id = 31,
                    Number = "PZ956",
                    ArrivalAirport = airports.GetAll().Single(a => a.Code == "ANH"),
                    ArrivalDate = DateTime.Parse("28/05/2008 20:10", cultureInfo),
                    DepartureAirport =  airports.GetAll().Single(a => a.Code == "OQO"),
                    DepartureDate = DateTime.Parse("29/05/2008 13:30", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "PZ"),
                    Price = 1140.5m
                },
                new Flight
                {
                    Id = 21,
                    Number = "BB768",
                    ArrivalAirport = airports.GetAll().Single(a => a.Code == "ANH"),
                    ArrivalDate = DateTime.Parse("14/11/2006 21:00", cultureInfo),
                    DepartureAirport =  airports.GetAll().Single(a => a.Code == "OQO"),
                    DepartureDate = DateTime.Parse("15/11/2006 01:30", cultureInfo),
                    Carrier = airlines.GetAll().Single(a => a.Code == "BB"),
                    Price = 416.17m
                }
            });
        }
    }
}
