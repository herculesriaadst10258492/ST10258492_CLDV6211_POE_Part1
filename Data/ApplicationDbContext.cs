using Microsoft.EntityFrameworkCore;
using Riaad_EventEase.Models;

namespace Riaad_EventEase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<AppEvent> AppEvents { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
