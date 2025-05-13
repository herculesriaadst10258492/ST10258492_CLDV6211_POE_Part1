using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Riaad_EventEase.Models
{
    public class AppEvent
    {
        public int AppEventID { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        public string EventDescription { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        // Foreign Key
        public int VenueID { get; set; }

        // Navigation Property
        public Venue Venue { get; set; } = null!;
    }
}
