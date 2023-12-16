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
        private readonly ILogger<HomeController> _logger;
        private readonly ProductRepository productRepository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            productRepository = new ProductRepository();
        }

        public IActionResult Index(int id)
        {
            //var product = productRepository.TryGetById(id);
            var products = productRepository.GetAll();
            string result = string.Empty;
            foreach (var product in products)
            {
                result += product + "\n\n";
            }
            //if (product == null)
            //{
            //    return $"Продукта с id={id} не существует"; 
            //}
            //return $"{product}\n{product.Description}";

            return View((object)result);
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