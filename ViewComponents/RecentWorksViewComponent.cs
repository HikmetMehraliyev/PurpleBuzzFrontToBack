using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;

namespace WebFrontToBack.ViewComponents
{
    public class RecentWorksViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public RecentWorksViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            List<Service> services = await _context.Services.ToListAsync();
            return View(services);
        }
    }
}
