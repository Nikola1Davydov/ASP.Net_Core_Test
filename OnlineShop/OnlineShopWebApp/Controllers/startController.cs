using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;
using System.Data;
using System.Globalization;

namespace OnlineShopWebApp.Controllers
{
    public class startController : Controller
    {
        //public IActionResult Index(string a, string b)
        //{
        //    return View();
        //}
        public string hello()
        {
            // По текущему времени выведите Доброе утро, Добрый день, Добрый вечер или Доброй ночи. 
            //Ночь - 0:00 до 05:59
            //Утро - 06:00 до 11:59
            //День - 12:00 до 17:59
            //Вечер - 18:00 до 23:59
            //TimeSpan localDate = DateTime.Now.TimeOfDay;
            TimeSpan localDate = new TimeSpan(07, 59, 59);

            if ( localDate > new TimeSpan(23, 59, 59) && localDate < new TimeSpan(05, 59, 59))
            {
                return "Доброй ночи";
            }
            else if (localDate > new TimeSpan(6, 00, 00) && localDate < new TimeSpan(11, 59, 59))
            {
                return "Доброе утро";
            }
            else if (localDate > new TimeSpan(12, 00, 00) && localDate < new TimeSpan(17, 59, 59))
            {
                return "Добрый день";
            }
            else
            {
                //localDate > new TimeSpan(23, 59, 0);
                return "Добрый вечер"; 
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
    }
}