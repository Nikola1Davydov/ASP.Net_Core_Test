using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;
using System.Data;
using System.Globalization;

namespace OnlineShopWebApp.Controllers
{
    public class calculatorController : Controller
    {
        //public IActionResult Index(string a, string b)
        //{
        //    return View();
        //}
        public string Index(int a, int b)
        {
            int sum = a + b;
            return a.ToString() + " + " + b.ToString() + " = " + sum.ToString();
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