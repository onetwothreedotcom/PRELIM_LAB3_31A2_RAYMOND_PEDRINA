using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_31A2_RAYMOND_PEDRIÑA.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_31A2_RAYMOND_PEDRIÑA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<IDescribable> customers = new List<IDescribable>
            {
                new Customer { Id = 1, Name = "Number One", Email = "1@gmail.com" },
                new VIP { Id = 2, Name = "Too Num", Email = "2@gmail.com", MembershipLevel = "VIP" }
            };

            return View(customers);
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
