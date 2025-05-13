using Riaad_EventEase.Models;

namespace Riaad_EventEase.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Venues.Any()) return;

            var venues = new Venue[]
            {
                new Venue { Name = "Grand Hall", Location = "Cape Town", Capacity = 500, ImageURL = "https://example.com/hall1.jpg" },
                new Venue { Name = "Skyline Arena", Location = "Joburg", Capacity = 800, ImageURL = "https://example.com/arena.jpg" }
            };
            context.Venues.AddRange(venues);
            context.SaveChanges();

            var events = new AppEvent[]
            {
                new AppEvent { EventName = "Tech Expo", EventDate = DateTime.Today, EventDescription = "A cool tech fair", ImageURL = "https://img.com/1.jpg", VenueID = venues[0].VenueID },
                new AppEvent { EventName = "Music Fest", EventDate = DateTime.Today.AddDays(5), EventDescription = "Live concert", ImageURL = "https://img.com/2.jpg", VenueID = venues[1].VenueID }
            };
            context.AppEvents.AddRange(events);
            context.SaveChanges();
        }
    }
}
