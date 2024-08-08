using _21bit03.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _21bit03.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly QlbanHangContext _context;

        public KhachHangController(QlbanHangContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _context.KhachHangs
                .Include(k => k.ThanhPhoNavigation)
                .ToListAsync();

            return View(customers); 
        }



    }
}
