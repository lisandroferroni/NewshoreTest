using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Reservation
    {
        [Key]
        public string PNR { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Passenger Passenger1 { get; set; }
        public Passenger Passenger2 { get; set; }

    }
}
