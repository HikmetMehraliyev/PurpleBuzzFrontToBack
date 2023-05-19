using Microsoft.AspNetCore.Mvc;
using WebFrontToBack.DAL;

namespace WebFrontToBack.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
