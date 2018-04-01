using System;
using System.Globalization;
using WingsOn.Domain;

namespace WingsOn.Dal
{
    public class PersonRepository : RepositoryBase<Person>
    {
        public PersonRepository() 
        {
            CultureInfo cultureInfo = new CultureInfo("nl-NL");

            Repository.AddRange(new []
            {
                new Person
                {
                    Id = 91,
                    Address = "805-1408 Mi Rd.",
                    DateBirth = DateTime.Parse("24/09/1980", cultureInfo),
                    Email = "egestas.a.dui@aliquet.ca",
                    Gender = GenderType.Male,
                    Name = "Kendall Velazquez"
                },
                new Person
                {
                    Id = 69,
                    Address = "P.O. Box 344, 5822 Curabitur Rd.",
                    DateBirth = DateTime.Parse("27/11/1948", cultureInfo),
                    Email = "non.cursus.non@turpisIncondimentum.co.uk",
                    Gender = GenderType.Female,
                    Name = "Claire Stephens"
                },
                new Person
                {
                    Id = 77,
                    Address = "P.O. Box 795, 1956 Odio. Rd.",
                    DateBirth = DateTime.Parse("01/01/1940", cultureInfo),
                    Email = "egestas.lacinia@Proinmi.com",
                    Gender = GenderType.Male,
                    Name = "Branden Johnston"
                },
                new Person
                {
                    Id = 96,
                    Address = "P.O. Box 660, 6702 Nunc St.",
                    DateBirth = DateTime.Parse("17/03/1981", cultureInfo),
                    Email = "leo.in.lobortis@accumsanconvallisante.ca",
                    Gender = GenderType.Male,
                    Name = "Germaine Fowler"
                },
                new Person
                {
                    Id = 25,
                    Address = "4320 Tempor Rd.",
                    DateBirth = DateTime.Parse("28/03/1959", cultureInfo),
                    Email = "elit@ligula.com",
                    Gender = GenderType.Female,
                    Name = "Debra Lang"
                },
                new Person
                {
                    Id = 59,
                    Address = "977-809 Morbi Avenue",
                    DateBirth = DateTime.Parse("01/01/1958", cultureInfo),
                    Email = "et@dictumeleifendnunc.org",
                    Gender = GenderType.Female,
                    Name = "Zenia Stout"
                },
                new Person
                {
                    Id = 24,
                    Address = "Ap #181-8446 In Avenue",
                    DateBirth = DateTime.Parse("29/01/1988", cultureInfo),
                    Email = "est.vitae@augueSed.ca",
                    Gender = GenderType.Female,
                    Name = "Emily Green"
                },
                new Person
                {
                    Id = 64,
		            Address = "7 Buell Park",
		            DateBirth = DateTime.Parse("04/10/1951" ,cultureInfo),
		            Gender = GenderType.Female,
		            Name = "Melissa Long",
		            Email = "mlong0@businesswire.com"
                },
                new Person
                {
                    Id = 13,
		            Address = "45200 Petterle Pass",
		            DateBirth = DateTime.Parse("15/06/1910", cultureInfo),
		            Gender = GenderType.Female,
		            Email = "kmorgan1@lycos.com",
		            Name = "Kathy Morgan"
                },
                new Person
                {
                    Id = 40,
		            Address = "3 Macpherson Junction",
		            DateBirth = DateTime.Parse("16/11/1977", cultureInfo),
		            Gender = GenderType.Male,
		            Email = "brice5@hostgator.com",
		            Name = "Bonnie Rice"
                },
                new Person
                {
                    Id = 18,
		            Address = "2258 Sloan Avenue",
		            DateBirth = DateTime.Parse("04/12/1962", cultureInfo),
		            Gender = GenderType.Female,
		            Email = "lharper6@adobe.com",
		            Name = "Louise Harper"
                }
            });
        }
    }
}
