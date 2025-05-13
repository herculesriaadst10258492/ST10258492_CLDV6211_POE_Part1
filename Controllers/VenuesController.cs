using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Riaad_EventEase.Models;

namespace Riaad_EventEase.Models
{
    public class AppEvent
    {
        public int EventID { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public string EventDescription { get; set; } = string.Empty;

        public string? ImageURL { get; set; }

        [ForeignKey("Venue")]
        public int VenueID { get; set; }

        public Venue? Venue { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
