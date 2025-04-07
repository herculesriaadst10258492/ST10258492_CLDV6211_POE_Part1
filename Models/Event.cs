using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Riaad_EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [ForeignKey("Venue")]
        public int VenueID { get; set; }

        public Venue? Venue { get; set; }
    }
}
