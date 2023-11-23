using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;
using System.Data;
using System.Globalization;

namespace OnlineShopWebApp.Controllers
{
    public class calcController : Controller
    {
        //public IActionResult Index(string a, string b)
        //{
        //    return View();
        //}
        public string Index(double a, double b, string c)
        {
            double sum;
            string warnung = "Вы передали не подходящий знак!";
            if (c == null) c = "+";

            if (c == "+")
            {
                sum = a + b;
            }
            else if (c == "*")
            {
                sum = a * b;
            }
            else if (c == "-")
            {
                sum = a - b;
            }
            else if (c == "/")
            {
                sum = a / b;
            }
            else return warnung;

            return a.ToString() +" " + c + " " + b.ToString() + " = " + sum.ToString();
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