using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Controllers
{
    [Route("api/[controller]")]
    public class RaceController : Controller
    {
        private ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var races = _context.Races.ToList();
            return View(races);
        }
        [HttpGet("getdetail")]
        public IActionResult Detail(int id)
        {
            var detail = _context.Races.Include(a=>a.Address).FirstOrDefault(r => r.Id == id);
            return View(detail);
        }
    }
}
