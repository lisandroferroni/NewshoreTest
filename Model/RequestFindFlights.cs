using System;

namespace Model
{
    public class RequestFindFlights
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime FromDate { get; set; }
    }
}
