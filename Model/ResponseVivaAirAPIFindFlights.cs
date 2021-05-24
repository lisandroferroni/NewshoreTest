using System;

namespace Model
{
    public class ResponseVivaAirAPIFindFlights
    {
        public DateTime DepartureDate { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string FlightNumber { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
    }
}
