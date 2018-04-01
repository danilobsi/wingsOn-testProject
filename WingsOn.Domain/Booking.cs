using System;
using System.Collections.Generic;

namespace WingsOn.Domain
{
    public class Booking : DomainObject
    {
        public string Number { get; set; }

        public Flight Flight { get; set; }

        public Person Customer { get; set; }

        public IEnumerable<Person> Passengers { get; set; }

        public DateTime DateBooking { get; set; }
    }
}
