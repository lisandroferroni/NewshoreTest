using Model.Entities;
using System.Collections.Generic;

namespace Data
{
    public interface INewShoreRepository
    {
        Flight Add(Flight flight);
        List<Passenger> GetAllPassengers();
        Passenger Add(Passenger passenger);
        Passenger Update(Passenger passenger);
        bool Delete(Passenger passenger);
        Reservation GetReservation(string NPR);
        Transport GetTransport(string flightNumber);
    }
}