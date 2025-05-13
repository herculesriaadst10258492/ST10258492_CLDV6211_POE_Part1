using System.ComponentModel.DataAnnotations;

namespace Riaad_EventEase.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int AppEventID { get; set; }

        public AppEvent AppEvent { get; set; } = null!;

        public int VenueID { get; set; }

        public Venue Venue { get; set; } = null!;

        [Required]
        public DateTime BookingDate { get; set; }
    }
}
