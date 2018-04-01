using System;

namespace WingsOn.Domain
{
    public class Person : DomainObject
    {
        public string Name { get; set; }

        public DateTime DateBirth { get; set; }

        public GenderType Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
    }
}
