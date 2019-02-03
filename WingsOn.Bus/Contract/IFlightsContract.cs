using WingsOn.Domain;

namespace WingsOn.Bus.Contract
{
    public interface IFlightsContract
    {
        Flight Get(int flightId);
    }
}