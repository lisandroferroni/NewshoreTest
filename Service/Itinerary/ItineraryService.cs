using Data;
using Model;
using Model.Entities;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class ItineraryService : IItineraryService
    {
        private readonly INewShoreRepository repo;
        public ItineraryService(
            INewShoreRepository repo)
        {
            this.repo = repo;
        }

        public List<Passenger> GetAllPassengers()
        {
            return this.repo.GetAllPassengers();
        }

        public Passenger UpdatePassenger(Passenger passenger)
        {
            return this.repo.Update(passenger);
        }

        public Reservation GetReservation(string NPR)
        {
            return this.repo.GetReservation(NPR);
        }
    }
}
