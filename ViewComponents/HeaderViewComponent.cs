using Microsoft.AspNetCore.Mvc;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;

namespace WebFrontToBack.ViewComponents
{
    public class HeaderViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

        private IViewComponentResult View()
        {
            throw new NotImplementedException();
        }
    }
}
