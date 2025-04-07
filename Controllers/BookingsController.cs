using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Riaad_EventEase.Data;
using Riaad_EventEase.Models;

namespace Riaad_EventEase.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var bookings = _context.Bookings
                .Include(b => b.Event)
                .Include(b => b.Venue);
            return View(await bookings.ToListAsync());
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["EventID"] = new SelectList(_context.Events, "EventID", "Name");
            ViewData["VenueID"] = new SelectList(_context.Venues, "VenueID", "Name");
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,BookingDate,EventID,VenueID")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["EventID"] = new SelectList(_context.Events, "EventID", "Name", booking.EventID);
            ViewData["VenueID"] = new SelectList(_context.Venues, "VenueID", "Name", booking.VenueID);
            return View(booking);
        }


    }
}
