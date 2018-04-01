using WingsOn.Domain;

namespace WingsOn.Dal
{
    public class AirlineRepository : RepositoryBase<Airline>
    {
        public AirlineRepository() 
        {
            Repository.AddRange(new []
            {
                new Airline
                {
                    Id = 8,
                    Code = "PZ",
                    Address = "P.O. Box 746, 3035 Urna. Av., Bailivre, Germany",
                    Name = "Ultrices Aviation Ltd"
                },
                new Airline
                {
                    Id = 45,
                    Code = "BB",
                    Address = "985-9762 Semper Street, Saint-Prime, Bolivia",
                    Name = "Proin Fly Corp"
                }
            });
        }
    }
}
