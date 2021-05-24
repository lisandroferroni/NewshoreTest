using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IVivaAirAPIService
    {
        Task<List<ResponseVivaAirAPIFindFlights>> FindFligthsAsync(RequestVivaAirAPIFindFlights request);
    }
}