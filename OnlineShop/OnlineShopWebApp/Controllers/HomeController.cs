using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using OnlineShopWebApp.Models;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using System.Xml.Linq;
using static OnlineShopWebApp.Controllers.HomeController;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;
        public HomeController()
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index(int id)
        {
            var products = productRepository.GetAll();
            return View(products);
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