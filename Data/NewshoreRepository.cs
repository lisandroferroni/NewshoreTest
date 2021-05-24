using Model;
using System;

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
    }
}
