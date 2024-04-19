using Code_First.Data;
using Code_First.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Code_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBcontext _logger;

        public HomeController(DBcontext logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<SinhVien> sinhVienList = _logger.SinhViens
               .Include(x => x.lop)
               .Include(x => x.lop.khoa)
               .Where(x => x.lop.khoaId == 1 && x.age >= 18 && x.age <= 20)
               .ToList();
            return View(sinhVienList);
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
