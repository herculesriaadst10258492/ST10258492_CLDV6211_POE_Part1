using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Riaad_EventEase.Models
{
    [Table("Venue")]
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public string ImageURL { get; set; } = string.Empty;


        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
