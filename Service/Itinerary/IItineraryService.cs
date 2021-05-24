using Model;
using Model.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IItineraryService
    {
        List<Passenger> GetAllPassengers();
        Passenger UpdatePassenger(Passenger passenger);
        Reservation GetReservation(string NPR);
    }
}