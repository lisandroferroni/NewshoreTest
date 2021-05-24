using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class NewshoreRepository : INewShoreRepository
    {
        private NewshoreDbContext context;
        public NewshoreRepository(NewshoreDbContext context)
        {
            this.context = context;
        }
        public Flight Add(Flight flight)
        {
            try
            {
                this.context.Flights.Add(flight);
                this.context.SaveChanges();
                return flight;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding new flight: " + e.Message);
            }
        }
        
        public Passenger Add(Passenger passenger)
        {
            try
            {
                this.context.Passengers.Add(passenger);
                this.context.SaveChanges();
                return passenger;
            }
            
            catch (Exception e)
            {
                throw new Exception("Error adding new passenger: " + e.Message);
            }
        }

        public Passenger Update(Passenger passenger)
        {
            try
            {
                this.context.Passengers.Update(passenger);
                this.context.SaveChanges();
                return passenger;
            }
            catch (Exception e)
            {
                throw new Exception("Error updating passenger: " + e.Message);
            }
        }

        public bool Delete(Passenger passenger)
        {
            try
            {
                this.context.Passengers.Remove(passenger);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting passenger: " + e.Message);
            }
        }

        public List<Passenger> GetAllPassengers()
        {
            try
            {
                return this.context.Passengers.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error getting passengers: " + e.Message);
            }
        }

        public Reservation GetReservation(string NPR)
        {
            return this.context.Reservations.Find(NPR);
        }

        public Transport GetTransport(string flightNumber)
        {
            return this.context.Transports.Find(flightNumber);
        }
    }
}
