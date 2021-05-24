using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IHomeService
    {
        public Task<List<ResponseFindFlights>> FindFlightsAsync(RequestFindFlights request);
        public Task<bool> SaveFlight(RequestSaveFlight request);
    }
}