using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ClubController : Controller
    {
        private ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
        [HttpGet("getdetail")]
        public IActionResult Detail(int id)
        {
            var club = _context.Clubs.Include(a=>a.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }


    }
}
