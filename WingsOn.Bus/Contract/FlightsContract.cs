using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Bus.Contract
{
    public class FlightsContract: IFlightsContract
    {
        IRepository<Flight> flightRepository;

        public FlightsContract(IRepository<Flight> flightRepository)
        {
            this.flightRepository = flightRepository;
        }

        public Flight Get(int flightId)
        {            
            return flightRepository.Get(flightId);
        }
    }
}
