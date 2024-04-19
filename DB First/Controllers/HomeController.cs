using DB_First.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DB_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlsvContext _logger;

        public HomeController(QlsvContext logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {        
            var sinhViensInCNTT = _logger.SinhViens.Include(x => x.Lop).ThenInclude(x => x.Khoa)
                .Where(sv => sv.Tuoi >= 18 && sv.Tuoi <= 20 && sv.Lop.Khoa.Ten == "CNTT")
                .ToList();
            return View(sinhViensInCNTT);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
