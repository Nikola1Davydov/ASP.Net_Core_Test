using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class WarenkorbController : Controller
    {
        private readonly ProductRepository productRepository;
        public WarenkorbController()
        {
            productRepository = new ProductRepository();
        }
        public IActionResult Index(int id)
        {

            var warenkorb = productRepository.GetWarenkorb();
            return View(warenkorb);
        }
    }
}
