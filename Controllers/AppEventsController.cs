using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riaad_EventEase.Data;
using Riaad_EventEase.Models;

namespace Riaad_EventEase.Controllers
{
    public class AppEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.AppEvents.Include(e => e.Venue).ToListAsync();
            return View(events);
        }

        // Add Create, Edit, Details, Delete actions if needed...
    }
}
