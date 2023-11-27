using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public void Index()
        {
            int counter = 3;
            for (int i = 0; i < counter; i++)
            {
                test(i);
            }
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
        private string test(int number)
        {
            string Id = "Id" + number;
            string Name = "Name" + number;
            string Cost = "Cost" + number;
            return Id + System.Environment.NewLine + Name + System.Environment.NewLine + Cost;
        }
    }
}