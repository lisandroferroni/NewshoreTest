using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Transport
    {
        [Key]
        public string FligthNumber { get; set; }
    }
}
