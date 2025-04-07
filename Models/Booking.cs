using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Riaad_EventEase.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [Required]
        public int EventID { get; set; }
        public Event? Event { get; set; }

        [Required]
        public int VenueID { get; set; }
        public Venue? Venue { get; set; }
    }
}
