using Microsoft.AspNetCore.Mvc;
using QlSanPham.Models;
using System.Diagnostics;

namespace QlSanPham.Controllers
{
    public class HomeController : Controller
    {
        QlspContext db = new QlspContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstsanpham = db.Categories.ToList();
            return View(lstsanpham);
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
