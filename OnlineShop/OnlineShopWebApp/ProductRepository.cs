using OnlineShopWebApp.Models;
using System.Text.Json;
using System.Linq;

namespace OnlineShopWebApp
{
    public class ProductRepository
    {
        private static Product[] ProductsFromJson()
        {
            string fileName = "MeineWarenFuerShop.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            return products;
        }
        private static List<Product> products = new List<Product>(ProductsFromJson());

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        private static List<Product> warenkorb = new List<Product>();

        public List<Product> GetWarenkorb()
        {
            return warenkorb;
        }
        public static void AddNewProductToWarenkorb(int id)
        {
            warenkorb.Add(products.FirstOrDefault(p => p.Id == id));
        }
    }
}
