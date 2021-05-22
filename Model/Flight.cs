using System;

namespace Model
{
    public class Flight
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public Transport Transport { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
    }
}
