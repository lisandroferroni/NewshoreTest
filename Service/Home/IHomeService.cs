using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IHomeService
    {
        public Task<List<ResponseFindFlights>> FindFlightsAsync(RequestFindFlights request);
        public bool SaveFlight(RequestSaveFlight request);
    }
}