using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riaad_EventEase.Data;

namespace Riaad_EventEase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookingsForEvent()
        {
            var bookings = _context.Bookings.Include(b => b.AppEvent).ToList();
            return View(bookings);
        }

        public IActionResult BookingCounts()
        {
            var counts = _context.Bookings
                .GroupBy(b => b.EventID)
                .Select(g => new
                {
                    EventID = g.Key,
                    Count = g.Count()
                }).ToList();
            return View(counts);
        }

        public IActionResult EventsWithoutBookings()
        {
            var events = _context.Events
                .Where(e => !_context.Bookings.Any(b => b.EventID == e.EventID))
                .ToList();
            return View(events);
        }

        public IActionResult LargeVenues()
        {
            var venues = _context.Venues
                .Where(v => v.Capacity > 400)
                .ToList();
            return View(venues);
        }



        public IActionResult UpcomingEvents()
        {
            var events = _context.Events
                .Where(e => e.EventDate > DateTime.Now)
                .ToList();
            return View(events);
        }
    }
}
