using System.ComponentModel.DataAnnotations;

namespace Riaad_EventEase.Models
{
    public class Venue
    {
        public int VenueID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public string ImageURL { get; set; } = string.Empty;

        public ICollection<AppEvent> AppEvents { get; set; } = new List<AppEvent>();
    }
}
