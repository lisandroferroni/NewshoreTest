using Data;
using Model;
using Model.Entities;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class HomeService : IHomeService
    {
        private readonly IVivaAirAPIService vivaAirAPIService;
        private readonly INewShoreRepository repo;
        public HomeService(IVivaAirAPIService vivaAirAPIService,
            INewShoreRepository repo)
        {
            this.vivaAirAPIService = vivaAirAPIService;
            this.repo = repo;
        }

        public async Task<List<ResponseFindFlights>> FindFlightsAsync(RequestFindFlights request)
        {
            RequestVivaAirAPIFindFlights apiRequest = CreateAPIRequest(request);            

            var apiResponse = await this.vivaAirAPIService.FindFligthsAsync(apiRequest);

            List<ResponseFindFlights> result = MapApiResponse(apiResponse);

            return result;
        }

        public bool SaveFlight(RequestSaveFlight request)
        {
            var transport = this.repo.GetTransport(request.FlightNumber);

            var flight = new Flight()
            {
                ArrivalStation = request.ArrivalStation,
                Currency = request.Currency,
                DepartureDate = request.DepartureDate,
                DepartureStation = request.DepartureStation,
                Price = request.Price,
                Transport = transport ?? new Transport() { FligthNumber = request.FlightNumber }
            };
            
            repo.Add(flight);

            return true;
        }

        private RequestVivaAirAPIFindFlights CreateAPIRequest(RequestFindFlights request)
        {
            return new RequestVivaAirAPIFindFlights()
            {
                Destination = request.Destination,
                From = request.FromDate.ToString("yyyy-MM-dd"),
                Origin = request.Origin
            };
        }

        private List<ResponseFindFlights> MapApiResponse(List<ResponseVivaAirAPIFindFlights> apiResponse)
        {
            var flightsList = new List<ResponseFindFlights>();

            foreach(var flight in apiResponse)
            {
                flightsList.Add(new ResponseFindFlights()
                {
                    ArrivalStation = flight.ArrivalStation,
                    Currency = flight.Currency,
                    DepartureDate = flight.DepartureDate,
                    DepartureStation = flight.DepartureStation,
                    FlightNumber = flight.FlightNumber,
                    Price = flight.Price
                });
            }

            return flightsList;
        }
    }
}
