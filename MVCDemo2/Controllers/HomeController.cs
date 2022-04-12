using Microsoft.AspNetCore.Mvc;

using MVCDemo2.Models;
using MVCDemo2.Services;

using System.Diagnostics;

namespace MVCDemo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TotalUsers _totalUsers;

        public HomeController(ILogger<HomeController> logger, TotalUsers totalUsers)
        {
            _logger = logger;
            _totalUsers = totalUsers;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _totalUsers.TUsers();
            return View();
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