using WingsOn.Domain;

namespace WingsOn.Bus.Contract
{
    public interface IBookingContract
    {
        string Create(Person passenger, int flightId);
    }
}