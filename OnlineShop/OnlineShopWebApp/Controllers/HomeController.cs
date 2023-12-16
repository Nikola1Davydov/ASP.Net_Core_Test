using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using OnlineShopWebApp.Models;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using System.Xml.Linq;
using static OnlineShopWebApp.Controllers.HomeController;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index(string id)
        {
            string fileName = "MeineWarenFuerShop.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            string result = string.Empty;
            foreach (var product in products)
            {
                if (product.id.ToString() == id)
                {
                    result += JsonInText(product);
                }
                
                //Console.WriteLine($"Id: {product.id}, Name: {product.Name}, Cost: {product.Cost}");
            }

            return result;
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
        public string JsonInText(Product testJson)
        {
            string test = testJson.id + System.Environment.NewLine + testJson.Name + System.Environment.NewLine + testJson.Cost + System.Environment.NewLine + System.Environment.NewLine;
            return test;
        }
        //private string test(int number)
        //{
        //    string result = "";
        //    for (int i = 1; i < number+1; i++)
        //    {
        //        string Id = "Id" + i;
        //        string Name = "Name" + i;
        //        string Cost = "Cost" + i;
        //        result += Id + System.Environment.NewLine + Name + System.Environment.NewLine + Cost + System.Environment.NewLine + System.Environment.NewLine;
        //    }
        //    return result;
        //}
        public class Product
        {
            public int id { get; set; }
            public string Name { get; set; }
            public double Cost { get; set; }

        }
    }
}